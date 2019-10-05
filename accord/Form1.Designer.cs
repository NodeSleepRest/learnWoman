namespace accord
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewImageColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.features = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnswerDigit = new System.Windows.Forms.ComboBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.tbLineWidth = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.myComponent1 = new accord.myComponent();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.myComponent1);
            this.panel1.Location = new System.Drawing.Point(292, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 128);
            this.panel1.TabIndex = 1;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.answer,
            this.features});
            this.dgvHistory.Location = new System.Drawing.Point(27, 109);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowTemplate.Height = 21;
            this.dgvHistory.Size = new System.Drawing.Size(240, 150);
            this.dgvHistory.TabIndex = 3;
            // 
            // data
            // 
            this.data.HeaderText = "データ";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // answer
            // 
            this.answer.HeaderText = "答え";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            // 
            // features
            // 
            this.features.HeaderText = "column3";
            this.features.Name = "features";
            this.features.ReadOnly = true;
            this.features.Visible = false;
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(450, 96);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(75, 23);
            this.btnLearn.TabIndex = 5;
            this.btnLearn.Text = "学習";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(450, 125);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion.TabIndex = 6;
            this.btnQuestion.Text = "出題";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "想定する答え";
            // 
            // cmbAnswerDigit
            // 
            this.cmbAnswerDigit.FormattingEnabled = true;
            this.cmbAnswerDigit.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbAnswerDigit.Location = new System.Drawing.Point(438, 184);
            this.cmbAnswerDigit.Name = "cmbAnswerDigit";
            this.cmbAnswerDigit.Size = new System.Drawing.Size(67, 20);
            this.cmbAnswerDigit.TabIndex = 8;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(450, 67);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 9;
            this.btnAddRow.Text = "行追加";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAnswer1.Location = new System.Drawing.Point(742, 67);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(0, 37);
            this.lblAnswer1.TabIndex = 10;
            // 
            // tbLineWidth
            // 
            this.tbLineWidth.Location = new System.Drawing.Point(292, 96);
            this.tbLineWidth.Maximum = 8;
            this.tbLineWidth.Minimum = 1;
            this.tbLineWidth.Name = "tbLineWidth";
            this.tbLineWidth.Size = new System.Drawing.Size(128, 45);
            this.tbLineWidth.TabIndex = 11;
            this.tbLineWidth.Value = 5;
            this.tbLineWidth.Scroll += new System.EventHandler(this.tbLineWidth_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAnswer2.Location = new System.Drawing.Point(742, 125);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(0, 24);
            this.lblAnswer2.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(438, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(44, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "消去";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // myComponent1
            // 
            this.myComponent1.Location = new System.Drawing.Point(0, 0);
            this.myComponent1.MaximumSize = new System.Drawing.Size(128, 128);
            this.myComponent1.MinimumSize = new System.Drawing.Size(128, 128);
            this.myComponent1.Name = "myComponent1";
            this.myComponent1.PenSize = 5;
            this.myComponent1.Size = new System.Drawing.Size(128, 128);
            this.myComponent1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbLineWidth);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.cmbAnswerDigit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private myComponent myComponent1;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnswerDigit;
        private System.Windows.Forms.DataGridViewImageColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn features;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.TrackBar tbLineWidth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Button btnClear;
    }
}

