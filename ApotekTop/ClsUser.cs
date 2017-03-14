using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ApotekTop
{
    class ClsUser : ClsKoneksi
    {
        string userName;
        public string UserName
        {
            get { return this.userName; }
        }
        public byte LoginPengguna(string namaPengguna, string kataSandi)
        {
            if (con_open() == true)
            {
                using (MySqlCommand perintah = new MySqlCommand("SELECT password FROM tbl_user WHERE username = '" + UserName.Replace(",", "").Replace("--", "") + "'", Koneksi))
                {
                    string password = (string)perintah.ExecuteScalar();
                    if(password != null)
                    {
                        if(password == kataSandi)
                        {
                            userName = namaPengguna;
                            return 0; //No Error                            
                        }
                        else
                        {
                            return 1; //Password Salah
                        }
                    }
                    else
                    {
                        return 2; //Uername Salah / tidak ditemukan
                    }                    
                }
            }
            else
            {
                return 4; // Koneksi Tidak ada
            }            
        }
    }
}
