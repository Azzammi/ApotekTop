using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApotekTop.Database
{
    public partial class FrmBackupDB : Form
    {
        CRUD crud = new CRUD();
        public FrmBackupDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog svd = new SaveFileDialog())
            {
                svd.Title = "Pilih lokasi penyimpanan";
                svd.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
                svd.FileName = "apotekDB.sql";
                svd.AddExtension = true;                
                svd.SupportMultiDottedExtensions = false;
                svd.Filter = "SQL|*.sql";
                                
                if (svd.ShowDialog() == DialogResult.OK)
                {
                    using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.stringkonek))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mB = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mB.ExportToFile(svd.FileName);
                                
                                MessageBox.Show(mB.ExportInfo.ToString());
                                conn.Close();
                            }
                        }
                    }
                }
            }                                 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
