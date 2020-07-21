using CarReportSystem.infosys202026DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> _carReports = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            //dgvCarReportData.DataSource = _carReports;
        }
        //データの登録
        private void btAdd_Click(object sender, EventArgs e)
        {
            /*CarReport carReport = new CarReport
            {
                CreatedDate = dtpCreatedDate.Value,
                Author = cbAuthor.Text,
                Maker = carmaker(),
                Name = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            setCombobox(cbAuthor.Text,cbCarName.Text);
            if (!string.IsNullOrWhiteSpace(cbAuthor.Text) && !string.IsNullOrWhiteSpace(cbCarName.Text))
            {
                _carReports.Insert(0, carReport);
                InitedAllClear();
                dgvCarReportData.ClearSelection();
                initButon();
                pictureButon();
            } else
            {
                MessageBox.Show("記録者と車名を入力してください", "エラーメッセージ");
            }*/

        }
        
        //コンボボックスに候補の追加
        private void setCombobox(string author,string name)
        {
            if (!string.IsNullOrWhiteSpace(author))
            {
                if (!cbAuthor.Items.Contains(author))
                {
                    cbAuthor.Items.Add(author);
                }
            }
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (!cbCarName.Items.Contains(name))
                {
                    cbCarName.Items.Add(name);
                }
            }
        }

        //選択
        private void dgvCarReportData_Click(object sender, EventArgs e)
        {
            var maker = dgvCarReportData.CurrentRow.Cells[3].Value;
            if (dgvCarReportData != null)
            {
                InitedAllClear();
                //選択したレコードのインデックスで指定した項目を取り出す。
                SetData();
                rbJudgmenton((string)maker);
                initButon();  
            }
        }
        //選択したデータの表示
        public void SetData()
        {
            var createddate = dgvCarReportData.CurrentRow.Cells[1].Value;//選択している行の指定したセルの値を取得
            var author = dgvCarReportData.CurrentRow.Cells[2].Value;//選択している行の指定したセルの値を取得
            var name = dgvCarReportData.CurrentRow.Cells[4].Value;//選択している行の指定したセルの値を取得
            var report = dgvCarReportData.CurrentRow.Cells[5].Value;//選択している行の指定したセルの値を取得
            var byteData = dgvCarReportData.CurrentRow.Cells[6].Value;

            
            dtpCreatedDate.Value = (DateTime)createddate;
            cbAuthor.Text = author.ToString();
            cbCarName.Text = name.ToString();
            tbReport.Text = report.ToString();
            if (!string.IsNullOrWhiteSpace(byteData.ToString()))
            {
                pbPicture.Image = ByteArrayToImage((byte[])byteData);
                pbSizemdoe();
                pictureButon();
            }

        }
        //修正
        private void btFix_Click(object sender, EventArgs e)
        {
            dgvCarReportData.CurrentRow.Cells[1].Value = dtpCreatedDate.Value;//選択している行の指定したセルの値を取得
            dgvCarReportData.CurrentRow.Cells[2].Value = cbAuthor.Text;//選択している行の指定したセルの値を取得
            dgvCarReportData.CurrentRow.Cells[4].Value = cbCarName.Text;//選択している行の指定したセルの値を取得
            dgvCarReportData.CurrentRow.Cells[5].Value = tbReport.Text;//選択している行の指定したセルの値を取得
            string maker = carmaker().ToString();
            dgvCarReportData.CurrentRow.Cells[3].Value = maker;
            var img = dgvCarReportData.CurrentRow.Cells[6].Value = pbPicture.Image;
            
            initButon();
            pictureButon();
            ImageToByteArray((Image)img);
            InitedAllClear();
            dgvCarReportData.ClearSelection();

            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202026DataSet);
        }

        //入力項目の削除
        private void InitedAllClear()
        {
            dtpCreatedDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
            initButon();
            pictureButon();
        }

        //画像の参照
        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPicture.FileName);
                pbSizemdoe();
                pictureButon();
            }
        }

        //画像の削除
        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202026DataSet);
        }

        //削除
        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvCarReportData.SelectedRows)
            {
                dgvCarReportData.Rows.Remove(row);
            }
            InitedAllClear();
            dgvCarReportData.ClearSelection();
        }

        //データベースに接続
        private void btOpen_Click(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202026DataSet.CarReport);
            dgvCarReportData.ClearSelection();
            btSave.Enabled = true;


        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        //保存
        private void btSave_Click(object sender, EventArgs e)
        {
            //データベース更新
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202026DataSet);

        }

        //終了
        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //ラジオボタン判定式
        private CarReport.CarMaker carmaker()
        {
            //LINQとラムダ式を使用
            //RadioButton selectMaker = (gbMaker.Controls.Cast<RadioButton>().FirstOrDefault(rb => rb.Checked));
            //return (CarReport.CarMaker)int.Parse(selectMaker.Tag.ToString());

            CarReport.CarMaker sentaku = 0;
            if (rbToyota.Checked)
            {
                sentaku = CarReport.CarMaker.トヨタ;
            } else if (rbSubaru.Checked)
            {
                sentaku = CarReport.CarMaker.スバル;
            } else if (rbNissan.Checked)
            {
                sentaku = CarReport.CarMaker.日産;
            } else if (rbHonda.Checked)
            {
                sentaku = CarReport.CarMaker.ホンダ;
            } else if (rbGaisya.Checked)
            {
                sentaku = CarReport.CarMaker.外車;
            } else if (rbAnother.Checked)
            {
                sentaku = CarReport.CarMaker.その他;
            }
            return sentaku;
        }

        //選択行のラジオボタンをオンにする
        private void rbJudgmenton(string maker)
        {
            

            switch (maker.ToString())
            {
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外車":
                    rbGaisya.Checked = true;
                    break;
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                default:
                    rbAnother.Checked = true;
                    break;
            }
        }

        //変更と削除と保存のボタンのマスク解除とマスク化メソッド
        private void initButon()
        {
            if (cbAuthor.Text == "")
            {
                btFix.Enabled = false;
                btDelete.Enabled = false;
            } else
            {
                btFix.Enabled = true;
                btDelete.Enabled = true;
            }
            //if (_carReports.Count <= 0)
            //{
            //    btFix.Enabled = false;
            //    btFix.Enabled = false;
            //} else
            //{
            //    btFix.Enabled = true;
            //    btDelete.Enabled = true;
            //}
        }
        //写真をクリアするボタンのマスク解除とマスク化
        private void pictureButon() 
        {
            if (pbPicture.Image == null)
            {
                btPictureDelete.Enabled = false;
            } else
            {
                btPictureDelete.Enabled = true;
            }
        }
        //画像のサイズ調整
        private void pbSizemdoe()
        {
            //ピクチャーボックスのサイズに画像を調整
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202026DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            btSave.Enabled = false;
            dgvCarReportData.Columns[0].Visible = false;
            initButon();
            pictureButon();
        }
        //新規作成
        private void btnewdata_Click(object sender, EventArgs e)
        {
            InitedAllClear();
            _carReports.Clear();
            initButon();
            pictureButon();
            
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202026DataSet);

        }

    }
}
