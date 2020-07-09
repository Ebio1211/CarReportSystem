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
            dgvCarReportData.DataSource = _carReports;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CarReport carReport = new CarReport
            {
                CreatedDate = dtpCreatedDate.Value,
                Author = cbAuthor.Text,
                Maker = carmaker(),
                Name = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            setCombobox(cbAuthor.Text,cbCarName.Text);
            
            _carReports.Insert(0, carReport);
            InitedAllClear();
            dgvCarReportData.ClearSelection();

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
        private void dgvCarReportData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_carReports.Count != 0)
            {
                //行の選択
                CarReport selectedreport = _carReports[dgvCarReportData.CurrentRow.Index];
                //選択行の表示
                dtpCreatedDate.Value = selectedreport.CreatedDate;
                cbAuthor.Text = selectedreport.Author;
                rbJudgmenton();
                cbCarName.Text = selectedreport.Name;
                tbReport.Text = selectedreport.Report;
                pbPicture.Image = selectedreport.Picture;
            }
        }

        //修正
        private void btFix_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCarReportData.SelectedRows)
            {
                CarReport selectedreport = _carReports[dgvCarReportData.CurrentRow.Index];

                //修正の上書き
                selectedreport.CreatedDate = dtpCreatedDate.Value;
                selectedreport.Author = cbAuthor.Text;
                selectedreport.Maker = carmaker();
                selectedreport.Name = cbCarName.Text;
                selectedreport.Report = tbReport.Text;
                selectedreport.Picture = pbPicture.Image;

                dgvCarReportData.Refresh();
                InitedAllClear();
                dgvCarReportData.ClearSelection();
            }

        }

        //入力項目の削除
        private void InitedAllClear()
        {
            dtpCreatedDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            rbJudgmentoff();
            pbPicture.Image = null;
        }

        //画像の参照
        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPicture.FileName);
                pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //画像の削除
        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        //削除
        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvCarReportData.SelectedRows)
            {
                dgvCarReportData.Rows.Remove(row);
            }
            InitedAllClear();
        }

        //開く
        private void btOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {

                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();

                        //逆シリアル化して読み込む
                        _carReports = (BindingList<CarReport>)formatter.Deserialize(fs);
                        dgvCarReportData.DataSource = _carReports;
                        //dgvCarData_Click(sender, e);
                        // 選択を解除
                        dgvCarReportData.ClearSelection();

                    } catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //保存
        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _carReports);
                    } catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
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
        private void rbJudgmenton()
        {
            CarReport selectedreport = _carReports[dgvCarReportData.CurrentRow.Index];
            if (selectedreport.Maker == CarReport.CarMaker.その他)
            {
                rbAnother.Checked = true;
            } else if (selectedreport.Maker == CarReport.CarMaker.スバル)
            {
                rbSubaru.Checked = true;
            } else if (selectedreport.Maker == CarReport.CarMaker.トヨタ)
            {
                rbToyota.Checked = true;
            } else if (selectedreport.Maker == CarReport.CarMaker.外車)
            {
                rbGaisya.Checked = true;
            } else if (selectedreport.Maker == CarReport.CarMaker.日産)
            {
                rbNissan.Checked = true;
            } else if (selectedreport.Maker == CarReport.CarMaker.ホンダ)
            {
                rbHonda.Checked = true;
            }
        }

        //選択行のラジオボタンをオフにする
        private void rbJudgmentoff()
        {
            CarReport selectedreport = _carReports[dgvCarReportData.CurrentRow.Index];
            if (selectedreport.Maker == CarReport.CarMaker.その他)
            {
                rbAnother.Checked = false;
            } else if (selectedreport.Maker == CarReport.CarMaker.スバル)
            {
                rbSubaru.Checked = false;
            } else if (selectedreport.Maker == CarReport.CarMaker.トヨタ)
            {
                rbToyota.Checked = false;
            } else if (selectedreport.Maker == CarReport.CarMaker.外車)
            {
                rbGaisya.Checked = false;
            } else if (selectedreport.Maker == CarReport.CarMaker.日産)
            {
                rbNissan.Checked = false;
            } else if (selectedreport.Maker == CarReport.CarMaker.ホンダ)
            {
                rbHonda.Checked = false;
            }
        }


    }
}
