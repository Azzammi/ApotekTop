using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ApotekTop
{
    class ClsKoneksi
    {
        public byte counter = 0;
        //public string SQL = null;

        DataSet ds;
        DataTable dt;
        public MySqlConnection koneksi;
        MySqlCommand perintah;
        MySqlDataAdapter da;
        MySqlDataReader rada;

        public bool con_open()
        {
            tryAgain:
            koneksi = new MySqlConnection(Properties.Settings.Default.stringkonek);
            koneksi.Open();
            
            if(koneksi.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {                
                counter += 1;
                if(counter == 3)
                {
                    MessageBox.Show("Koneksi Error, Cek Koneksi Database ! " + counter, "Error Connection 404", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }                
                goto tryAgain;                        
            }
        }               

        public void con_close()
        {
            if((koneksi.State == ConnectionState.Closed) || (koneksi.State == ConnectionState.Open))
            {
                koneksi.Close();
                koneksi = null;
            }
        }

        public MySqlConnection Koneksi
        {
            get { return this.koneksi;  }
            //set { this.koneksi = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);   }
            set { this.koneksi = new MySqlConnection(Properties.Settings.Default.stringkonek); }
        }

        public MySqlCommand Perintah
        {
            get{ return this.perintah; }
            set{ this.perintah = value; }
        }

        public MySqlDataAdapter Da
        {
            get { return this.da; }
            set { this.da = value; }
        }

        public DataTable Dt
        {
            get { return this.dt; }
            set { this.dt = value;  }
        }

        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value;  }
        }

        public MySqlDataReader RaDa
        {
            get { return this.rada;  }
            set { this.rada = value;  }
        }
    }
}
