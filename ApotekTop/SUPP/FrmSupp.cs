using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApotekTop.SUPP
{
    public partial class FrmSupp : Form
    {
        CRUD crud = new CRUD();
        bool isEdit;
        public FrmSupp()
        {
            InitializeComponent();
            Pengaturan();
        }
        public string PrimaryKey
        {
            get { return this.kdSuppTXT.Text; }
            set { this.kdSuppTXT.Text = value; }
        }
        public bool IsEdit
        {
            get { return this.isEdit; }
            set { this.isEdit = value; }
        }
        private void FrmSupp_Load(object sender, EventArgs e)
        {

        }
        private void Pengaturan()
        {
            if (IsEdit)
            {
                kdSuppTXT.Enabled = false;
                nmSuppTXT.Focus();
            }
            else
            {
                kdSuppTXT.Enabled = true;
                ClsControl setControl = new ClsControl();
                setControl.EmptyText(this);
                kdSuppTXT.Focus();
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                if (crud.con_open())
                {
                    using (crud.Perintah = new MySqlCommand("UPDATE tbl_supplier SET nm_supp = @nama," +
                                                                    "alamat_supp = @alamat," +
                                                                    "kota_supp = @kota," +
                                                                    "telp_supp = @telp," +
                                                                    "email_supp = @email," +
                                                                    "nm_kontak_supp = @cp WHERE kd_supp = @kode", crud.Koneksi))
                    {
                        crud.Perintah.Parameters.Clear();
                        crud.Perintah.Parameters.AddWithValue("@kode", kdSuppTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@nama", nmSuppTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@alamat", alamatTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@kota", kotaTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@telp", teleponTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@email", emailTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@cp", nmKontakTXT.Text);
                        crud.Perintah.ExecuteNonQuery();

                        crud.con_close();
                    }
                }
                isEdit = false;
                Pengaturan();
                this.Close();
            }
            else
            {
                if (crud.con_open())
                {
                    using (crud.Perintah = new MySqlCommand("INSERT INTO tbl_supplier (kd_supp,nm_supp,alamat_supp,kota_supp,telp_supp,email_supp,nm_kontak_supp) VALUES " +
                                                        "(@kode,@nama,@alamat,@kota,@telp,@email,@cp)", crud.Koneksi))
                    {
                        crud.Perintah.Parameters.Clear();
                        crud.Perintah.Parameters.AddWithValue("@kode", kdSuppTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@nama", nmSuppTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@alamat", alamatTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@kota", kotaTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@telp", teleponTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@email", emailTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@cp", nmKontakTXT.Text);
                        crud.Perintah.ExecuteNonQuery();

                        crud.con_close();
                    }
                }
                isEdit = false;
                Pengaturan();       
            }
        }
    }
}
