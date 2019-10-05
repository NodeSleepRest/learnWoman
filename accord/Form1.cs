using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Accord.Statistics.Analysis;
using Accord.Statistics.Kernels;
using Accord.Math;

namespace accord
{
    public partial class Form1 : Form
    {
        KernelDiscriminantAnalysis kda;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // データ読み込み
            string[] strReadLines = File.ReadAllLines(string.Concat(Directory.GetCurrentDirectory(), "\\data.txt")); ;

            dgvHistory.Rows.Clear();
            dgvHistory.RowTemplate.Height = 32;
            cmbAnswerDigit.SelectedIndex = 0;
            btnLearn.Enabled = false;
            btnQuestion.Enabled = false;

            // 読み込みデータをグリッドに追加
            for (int i = 0; i < strReadLines.Length; i += 2)
            {
                dgvHistory.Rows.Add(convertStringToBitmap(strReadLines[i]), strReadLines[i + 1], convertStringToDouble(strReadLines[i]));
            }

            if (dgvHistory.Rows.Count >= 10)
            {
                btnLearn.Enabled = true;
            }
        }

        /// <summary>
        /// 行追加ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            // キャンパスに描いたデータを取得
            double[] input = myComponent1.GetDigit();

            //キャンパスデータをビットマップに変換
            Bitmap bitmap = convertDoubleToBitmap(input);

            // ビットマップデータと想定する答えをグリッドに追加
            dgvHistory.Rows.Add(bitmap, cmbAnswerDigit.SelectedItem.ToString(), input);

            // コンボボックス操作
            //cmbAnswerDigit.Items.Remove(cmbAnswerDigit.SelectedItem.ToString());
            if (cmbAnswerDigit.Items.Count > 0)
            {
                cmbAnswerDigit.SelectedIndex = 0;
            }
            else if (cmbAnswerDigit.Items.Count == 0)
            {
                if (dgvHistory.Rows.Count >= 10)
                {
                    btnLearn.Enabled = true;
                }

                initCmbbox();

                cmbAnswerDigit.SelectedIndex = 0;
            }

            // キャンパス初期化
            myComponent1.Clear();
        }

        /// <summary>
        /// 学習ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLearn_Click(object sender, EventArgs e)
        {
            int cntRows = dgvHistory.Rows.Count;
            double[][] input = Jagged.Zeros(cntRows, 32 * 32);
            int[] output = new int[cntRows];
            string tmpCharDigit;

            // グリッドのデータを1行ずつ学習データとして格納
            for (int i = 0; i < cntRows; i++)
            {
                input.SetRow(i, (double[])dgvHistory.Rows[i].Cells["features"].Value);

                tmpCharDigit = dgvHistory.Rows[i].Cells["answer"].Value.ToString();
                output[i] = int.Parse(tmpCharDigit);
            }

            IKernel kernel;
            kernel = new Polynomial(2, 0.0000);


            kda = new KernelDiscriminantAnalysis(kernel)
            {
                Threshold = 0.0005,
                Regularization = 0.0001
            };

            Application.DoEvents();

            kda.Learn(input, output);

            btnQuestion.Enabled = true;
        }

        /// <summary>
        /// 出題ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            const string strAnswer1 = "答えは…{0}！";
            const string strAnswer2 = "いや待って、{0}かもしれない";

            // キャンパスに描いたデータを取得
            double[] input = myComponent1.GetDigit();
            int num;

            // 入力したデータを判別
            double[] responses = kda.Classifier.Scores(input, out num);

            // Scale the responses to a [0,1] interval
            responses = Vector.Scale(responses, 0.0, 1.0);

            // Set the actual classification answer 
            lblAnswer1.Text = String.Format(strAnswer1, num.ToString());
            lblAnswer2.Text = String.Format(strAnswer2, getSecondDigit(responses, num).ToString());
        }

        /// <summary>
        /// フォームクローズ時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string[] dblLearnDigits = new string[dgvHistory.Rows.Count * 2];

            // グリッドデータに行がある場合ファイル出力
            if (dgvHistory.Rows.Count != 0)
            {
                for (int i = 0; i < dgvHistory.Rows.Count; i++)
                {
                    dblLearnDigits[i * 2] = convertDoubleArrayToString((double[])dgvHistory.Rows[i].Cells["features"].Value);
                    dblLearnDigits[i * 2 + 1] = dgvHistory.Rows[i].Cells["answer"].Value.ToString();
                }
                // グリッドデータの出力
                File.WriteAllLines(string.Concat(Directory.GetCurrentDirectory(), "\\data.txt"), dblLearnDigits);
            }
        }

        /// <summary>
        /// 消去ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            myComponent1.Clear();
        }

        /// <summary>
        /// 線の太さを決める
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbLineWidth_Scroll(object sender, EventArgs e)
        {
            myComponent1.PenSize = tbLineWidth.Value;
        }

        /// <summary>
        /// コンボボックス初期化
        /// </summary>
        private void initCmbbox()
        {
            cmbAnswerDigit.Items.Add("0");
            cmbAnswerDigit.Items.Add("1");
            cmbAnswerDigit.Items.Add("2");
            cmbAnswerDigit.Items.Add("3");
            cmbAnswerDigit.Items.Add("4");
            cmbAnswerDigit.Items.Add("5");
            cmbAnswerDigit.Items.Add("6");
            cmbAnswerDigit.Items.Add("7");
            cmbAnswerDigit.Items.Add("8");
            cmbAnswerDigit.Items.Add("9");
        }

        /// <summary>
        /// 2番目にありそうな数字を取得
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        private int getSecondDigit(double[] digits, int firstNum)
        {
            double tmp = digits[0];
            int secondNum = 0;

            for(int i=1; i<digits.Length; i++)
            {
                if(i == firstNum)
                {
                    continue;
                }

                if(digits[i] > tmp)
                {
                    tmp = digits[i];
                    secondNum = i;
                }
            }

            return secondNum;
        }

        /// <summary>
        /// Double型の配列をBitmapに変換
        /// </summary>
        /// <param name="buf">変換元となる数値データ</param>
        /// <returns></returns>
        private Bitmap convertDoubleToBitmap(double[] buf)
        {
            Bitmap bitmap = new Bitmap(32, 32, PixelFormat.Format32bppRgb);

            for (int i = 0; i < 1024; i++)
            {
                if (buf[i] == 0)
                    bitmap.SetPixel(i % 32, i / 32, Color.White);
                else
                    bitmap.SetPixel(i % 32, i / 32, Color.Black);
            }
            return bitmap;
        }

        /// <summary>
        /// String型をBitmapに変換
        /// </summary>
        /// <param name="buf">変換元となる数値データ</param>
        /// <returns></returns>
        private Bitmap convertStringToBitmap(string buf)
        {
            Bitmap bitmap = new Bitmap(32, 32, PixelFormat.Format32bppRgb);

            for (int i = 0; i < buf.Length; i++)
            {
                if (buf.Substring(i,1) == "0")
                    bitmap.SetPixel(i % 32, i / 32, Color.White);
                else
                    bitmap.SetPixel(i % 32, i / 32, Color.Black);
            }
            return bitmap;
        }

        /// <summary>
        /// String型をDouble型配列に変換
        /// </summary>
        /// <param name="buf">変換元となる数値データ</param>
        /// <returns></returns>
        private double[] convertStringToDouble(string buf)
        {
            double[] dblDigits = new double[buf.Length];

            for (int i = 0; i < buf.Length; i++)
            {
                if (buf.Substring(i, 1) == "0")
                    dblDigits[i] = 0;
                else
                    dblDigits[i] = 1;
            }
            return dblDigits;
        }

        /// <summary>
        /// double型の配列をString型に変換
        /// </summary>
        /// <param name="digits">変換元となる数値データ</param>
        /// <returns></returns>
        private string convertDoubleArrayToString(double[] digits)
        {
            StringBuilder sb = new StringBuilder();

            for (int i=0; i<digits.Length; i++)
            {
                sb.Append(digits[i].ToString());
            }

            return sb.ToString();
        }
    }
}
