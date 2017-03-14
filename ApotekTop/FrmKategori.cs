using System;

using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ApotekTop
{
    public partial class FrmKategori : Form
    {
        CRUD crud = new CRUD();
        string primaryKey;
        bool isEdit;
        public FrmKategori()
        {
            InitializeComponent();
        }
        public string PrimaryKey
        {
            get { return this.primaryKey; }
            set { this.primaryKey = value;}
        }
        public bool IsEdit
        {
            get { return this.isEdit; }
            set { this.isEdit = value; }
        }
        public void Pengaturan()
        {
            kategoriTxt.Clear();
            kategoriTxt.Focus();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                if (crud.con_open())
                {
                    using (crud.Perintah = new MySqlCommand("update tbl_kategori set kategori = @kategori WHERE id_kategori = @id", crud.Koneksi))
                    {
                        crud.Perintah.Parameters.Clear();
                        crud.Perintah.Parameters.AddWithValue("@kategori", kategoriTxt.Text);
                        crud.Perintah.Parameters.AddWithValue("@id", primaryKey);
                        crud.Perintah.ExecuteNonQuery();

                        crud.con_close();
                    }
                }
                IsEdit = false;
                Pengaturan();
                this.Close();
            }
            else
            {                
                crud.Insert("tbl_kategori", "kategori = '" + kategoriTxt.Text + "'");
                IsEdit = false;
                Pengaturan();
            }            
        }
    }
}
