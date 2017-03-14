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
    public partial class frmRestoreDB : Form
    {
        CRUD crud = new CRUD();
        public frmRestoreDB()
        {
            InitializeComponent();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog())
            {
                opd.Title = "Pilih File Backup Database";
                opd.Filter = ".SQL|*.sql";
                opd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                opd.Multiselect = false;
                if(opd.ShowDialog() == DialogResult.OK)
                {
                    if (crud.con_open())
                    {
                        using (crud.Perintah = new MySqlCommand())
                        {
                            using (MySqlBackup mB = new MySqlBackup(crud.Perintah))
                            {
                                crud.Perintah.Connection = crud.Koneksi;
                                mB.ImportFromFile(opd.FileName);
                                crud.con_close();
                                MessageBox.Show(mB.ImportInfo.ToString());
                            }
                        }
                    }
                }
            }
        }
    }
}
