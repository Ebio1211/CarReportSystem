namespace CarReportSystem
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTimeData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbReporter = new System.Windows.Forms.ComboBox();
            this.cbbCarName = new System.Windows.Forms.ComboBox();
            this.cbToyota = new System.Windows.Forms.CheckBox();
            this.cbNissan = new System.Windows.Forms.CheckBox();
            this.cbHonda = new System.Windows.Forms.CheckBox();
            this.cbSubaru = new System.Windows.Forms.CheckBox();
            this.cbGaisya = new System.Windows.Forms.CheckBox();
            this.cbAnother = new System.Windows.Forms.CheckBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCarReportData = new System.Windows.Forms.DataGridView();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpTimeData
            // 
            this.dtpTimeData.Location = new System.Drawing.Point(99, 17);
            this.dtpTimeData.Name = "dtpTimeData";
            this.dtpTimeData.Size = new System.Drawing.Size(200, 19);
            this.dtpTimeData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // cbbReporter
            // 
            this.cbbReporter.FormattingEnabled = true;
            this.cbbReporter.Location = new System.Drawing.Point(99, 56);
            this.cbbReporter.Name = "cbbReporter";
            this.cbbReporter.Size = new System.Drawing.Size(253, 20);
            this.cbbReporter.TabIndex = 2;
            // 
            // cbbCarName
            // 
            this.cbbCarName.FormattingEnabled = true;
            this.cbbCarName.Location = new System.Drawing.Point(99, 137);
            this.cbbCarName.Name = "cbbCarName";
            this.cbbCarName.Size = new System.Drawing.Size(253, 20);
            this.cbbCarName.TabIndex = 2;
            // 
            // cbToyota
            // 
            this.cbToyota.AutoSize = true;
            this.cbToyota.Location = new System.Drawing.Point(99, 97);
            this.cbToyota.Name = "cbToyota";
            this.cbToyota.Size = new System.Drawing.Size(48, 16);
            this.cbToyota.TabIndex = 3;
            this.cbToyota.Text = "トヨタ";
            this.cbToyota.UseVisualStyleBackColor = true;
            // 
            // cbNissan
            // 
            this.cbNissan.AutoSize = true;
            this.cbNissan.Location = new System.Drawing.Point(153, 97);
            this.cbNissan.Name = "cbNissan";
            this.cbNissan.Size = new System.Drawing.Size(48, 16);
            this.cbNissan.TabIndex = 3;
            this.cbNissan.Text = "日産";
            this.cbNissan.UseVisualStyleBackColor = true;
            // 
            // cbHonda
            // 
            this.cbHonda.AutoSize = true;
            this.cbHonda.Location = new System.Drawing.Point(207, 97);
            this.cbHonda.Name = "cbHonda";
            this.cbHonda.Size = new System.Drawing.Size(52, 16);
            this.cbHonda.TabIndex = 3;
            this.cbHonda.Text = "ホンダ";
            this.cbHonda.UseVisualStyleBackColor = true;
            // 
            // cbSubaru
            // 
            this.cbSubaru.AutoSize = true;
            this.cbSubaru.Location = new System.Drawing.Point(261, 98);
            this.cbSubaru.Name = "cbSubaru";
            this.cbSubaru.Size = new System.Drawing.Size(53, 16);
            this.cbSubaru.TabIndex = 3;
            this.cbSubaru.Text = "スバル";
            this.cbSubaru.UseVisualStyleBackColor = true;
            // 
            // cbGaisya
            // 
            this.cbGaisya.AutoSize = true;
            this.cbGaisya.Location = new System.Drawing.Point(320, 98);
            this.cbGaisya.Name = "cbGaisya";
            this.cbGaisya.Size = new System.Drawing.Size(48, 16);
            this.cbGaisya.TabIndex = 3;
            this.cbGaisya.Text = "外車";
            this.cbGaisya.UseVisualStyleBackColor = true;
            // 
            // cbAnother
            // 
            this.cbAnother.AutoSize = true;
            this.cbAnother.Location = new System.Drawing.Point(379, 98);
            this.cbAnother.Name = "cbAnother";
            this.cbAnother.Size = new System.Drawing.Size(55, 16);
            this.cbAnother.TabIndex = 3;
            this.cbAnother.Text = "その他";
            this.cbAnother.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(99, 188);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(377, 111);
            this.tbReport.TabIndex = 4;
            this.tbReport.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // dgvCarReportData
            // 
            this.dgvCarReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReportData.Location = new System.Drawing.Point(99, 319);
            this.dgvCarReportData.Name = "dgvCarReportData";
            this.dgvCarReportData.RowTemplate.Height = 21;
            this.dgvCarReportData.Size = new System.Drawing.Size(644, 188);
            this.dgvCarReportData.TabIndex = 5;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(22, 350);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(57, 35);
            this.btOpen.TabIndex = 6;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(22, 391);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(57, 35);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(506, 44);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(237, 229);
            this.pbCar.TabIndex = 7;
            this.pbCar.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(506, 279);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(57, 20);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(601, 279);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(57, 20);
            this.btFix.TabIndex = 6;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(686, 279);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(57, 20);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(601, 18);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(57, 20);
            this.btPictureOpen.TabIndex = 6;
            this.btPictureOpen.Text = "開く";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(686, 18);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(57, 20);
            this.btPictureDelete.TabIndex = 6;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.dgvCarReportData);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbAnother);
            this.Controls.Add(this.cbGaisya);
            this.Controls.Add(this.cbSubaru);
            this.Controls.Add(this.cbHonda);
            this.Controls.Add(this.cbNissan);
            this.Controls.Add(this.cbToyota);
            this.Controls.Add(this.cbbCarName);
            this.Controls.Add(this.cbbReporter);
            this.Controls.Add(this.dtpTimeData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTimeData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbReporter;
        private System.Windows.Forms.ComboBox cbbCarName;
        private System.Windows.Forms.CheckBox cbToyota;
        private System.Windows.Forms.CheckBox cbNissan;
        private System.Windows.Forms.CheckBox cbHonda;
        private System.Windows.Forms.CheckBox cbSubaru;
        private System.Windows.Forms.CheckBox cbGaisya;
        private System.Windows.Forms.CheckBox cbAnother;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCarReportData;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Label label7;
    }
}

