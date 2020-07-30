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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbAnother = new System.Windows.Forms.RadioButton();
            this.rbGaisya = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.btEnd = new System.Windows.Forms.Button();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.btnewdata = new System.Windows.Forms.Button();
            this.dgvCarReportData = new System.Windows.Forms.DataGridView();
            this.tbSearchCarName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpSearchCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSearchMaker = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202026DataSet = new CarReportSystem.infosys202026DataSet();
            this.carReportTableAdapter = new CarReportSystem.infosys202026DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202026DataSetTableAdapters.TableAdapterManager();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.rbOr = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReportData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202026DataSet)).BeginInit();
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
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Location = new System.Drawing.Point(99, 17);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 19);
            this.dtpCreatedDate.TabIndex = 1;
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
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(99, 56);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(253, 20);
            this.cbAuthor.TabIndex = 2;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(99, 137);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(253, 20);
            this.cbCarName.TabIndex = 2;
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
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(22, 350);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(57, 35);
            this.btOpen.TabIndex = 6;
            this.btOpen.Text = "接続";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(22, 391);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(57, 35);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(506, 56);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(237, 217);
            this.pbPicture.TabIndex = 7;
            this.pbPicture.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(506, 279);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(57, 29);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(601, 279);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(57, 29);
            this.btFix.TabIndex = 6;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(686, 279);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(57, 29);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(601, 18);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(57, 20);
            this.btPictureOpen.TabIndex = 6;
            this.btPictureOpen.Text = "開く";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(686, 18);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(57, 20);
            this.btPictureDelete.TabIndex = 6;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            this.btPictureDelete.Click += new System.EventHandler(this.btPictureDelete_Click);
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
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbAnother);
            this.gbMaker.Controls.Add(this.rbGaisya);
            this.gbMaker.Controls.Add(this.rbSubaru);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Controls.Add(this.rbNissan);
            this.gbMaker.Controls.Add(this.rbToyota);
            this.gbMaker.Location = new System.Drawing.Point(99, 83);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(336, 35);
            this.gbMaker.TabIndex = 8;
            this.gbMaker.TabStop = false;
            // 
            // rbAnother
            // 
            this.rbAnother.AutoSize = true;
            this.rbAnother.Location = new System.Drawing.Point(265, 10);
            this.rbAnother.Name = "rbAnother";
            this.rbAnother.Size = new System.Drawing.Size(54, 16);
            this.rbAnother.TabIndex = 0;
            this.rbAnother.Tag = "5";
            this.rbAnother.Text = "その他";
            this.rbAnother.UseVisualStyleBackColor = true;
            // 
            // rbGaisya
            // 
            this.rbGaisya.AutoSize = true;
            this.rbGaisya.Location = new System.Drawing.Point(212, 10);
            this.rbGaisya.Name = "rbGaisya";
            this.rbGaisya.Size = new System.Drawing.Size(47, 16);
            this.rbGaisya.TabIndex = 0;
            this.rbGaisya.Tag = "4";
            this.rbGaisya.Text = "外車";
            this.rbGaisya.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(159, 11);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 0;
            this.rbSubaru.Tag = "3";
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(106, 10);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 0;
            this.rbHonda.Tag = "2";
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(53, 10);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 0;
            this.rbNissan.Tag = "1";
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Checked = true;
            this.rbToyota.Location = new System.Drawing.Point(0, 11);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 0;
            this.rbToyota.TabStop = true;
            this.rbToyota.Tag = "0";
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(672, 513);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(71, 35);
            this.btEnd.TabIndex = 6;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // btnewdata
            // 
            this.btnewdata.Location = new System.Drawing.Point(99, 513);
            this.btnewdata.Name = "btnewdata";
            this.btnewdata.Size = new System.Drawing.Size(113, 35);
            this.btnewdata.TabIndex = 9;
            this.btnewdata.Text = "新規作成";
            this.btnewdata.UseVisualStyleBackColor = true;
            this.btnewdata.Click += new System.EventHandler(this.btnewdata_Click);
            // 
            // dgvCarReportData
            // 
            this.dgvCarReportData.AllowUserToAddRows = false;
            this.dgvCarReportData.AutoGenerateColumns = false;
            this.dgvCarReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.dgvCarReportData.DataSource = this.carReportBindingSource;
            this.dgvCarReportData.Location = new System.Drawing.Point(96, 314);
            this.dgvCarReportData.MultiSelect = false;
            this.dgvCarReportData.Name = "dgvCarReportData";
            this.dgvCarReportData.ReadOnly = true;
            this.dgvCarReportData.RowTemplate.Height = 21;
            this.dgvCarReportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReportData.Size = new System.Drawing.Size(647, 193);
            this.dgvCarReportData.TabIndex = 23;
            this.dgvCarReportData.Click += new System.EventHandler(this.dgvCarReportData_Click);
            // 
            // tbSearchCarName
            // 
            this.tbSearchCarName.Location = new System.Drawing.Point(3, 59);
            this.tbSearchCarName.Name = "tbSearchCarName";
            this.tbSearchCarName.Size = new System.Drawing.Size(286, 19);
            this.tbSearchCarName.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "車名";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rbOr);
            this.groupBox1.Controls.Add(this.rbAnd);
            this.groupBox1.Controls.Add(this.dtpSearchCreatedDate);
            this.groupBox1.Controls.Add(this.btSearchExe);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSearchMaker);
            this.groupBox1.Controls.Add(this.tbSearchCarName);
            this.groupBox1.Location = new System.Drawing.Point(782, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 217);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // dtpSearchCreatedDate
            // 
            this.dtpSearchCreatedDate.Location = new System.Drawing.Point(3, 112);
            this.dtpSearchCreatedDate.Name = "dtpSearchCreatedDate";
            this.dtpSearchCreatedDate.Size = new System.Drawing.Size(286, 19);
            this.dtpSearchCreatedDate.TabIndex = 32;
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(96, 185);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(75, 23);
            this.btSearchExe.TabIndex = 26;
            this.btSearchExe.Text = "実行";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "メーカー";
            // 
            // tbSearchMaker
            // 
            this.tbSearchMaker.Location = new System.Drawing.Point(3, 160);
            this.tbSearchMaker.Name = "tbSearchMaker";
            this.tbSearchMaker.Size = new System.Drawing.Size(286, 19);
            this.tbSearchMaker.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202026DataSet;
            // 
            // infosys202026DataSet
            // 
            this.infosys202026DataSet.DataSetName = "infosys202026DataSet";
            this.infosys202026DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202026DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "日付";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "検索方法：";
            // 
            // rbAnd
            // 
            this.rbAnd.AutoSize = true;
            this.rbAnd.Location = new System.Drawing.Point(116, 15);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(47, 16);
            this.rbAnd.TabIndex = 33;
            this.rbAnd.TabStop = true;
            this.rbAnd.Text = "AND";
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // rbOr
            // 
            this.rbOr.AutoSize = true;
            this.rbOr.Location = new System.Drawing.Point(169, 15);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(39, 16);
            this.rbOr.TabIndex = 33;
            this.rbOr.TabStop = true;
            this.rbOr.Text = "OR";
            this.rbOr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCarReportData);
            this.Controls.Add(this.btnewdata);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReportData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202026DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbAnother;
        private System.Windows.Forms.RadioButton rbGaisya;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.Button btnewdata;
        private infosys202026DataSet infosys202026DataSet;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202026DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202026DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCarReportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox tbSearchCarName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSearchMaker;
        private System.Windows.Forms.DateTimePicker dtpSearchCreatedDate;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

