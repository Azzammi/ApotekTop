
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ApotekTop
{
    class CRUD : ClsKoneksi
    {
               
        public DataTable Select(string nama_tabel, string query)
        {
            if (con_open())
            {
                string sql = "SELECT " + query + " FROM " + nama_tabel;
                using (Perintah = new MySqlCommand(sql, Koneksi))
                {
                    Perintah.CommandTimeout = 0;

                    Da = new MySqlDataAdapter();
                    Da.SelectCommand = Perintah;

                    Ds = new DataSet();
                    Da.Fill(Ds);

                    Dt = Ds.Tables[0];
                    return Dt;            
                }
            }
            con_close();
            return null;                        
        }

        public DataTable ExecuteQuery(string sql)
        {
            if (con_open())
            {                
                using (Perintah = new MySqlCommand(sql, Koneksi))
                {
                    Perintah.CommandTimeout = 0;

                    Da = new MySqlDataAdapter();
                    Da.SelectCommand = Perintah;

                    Ds = new DataSet();
                    Da.Fill(Ds);

                    Dt = Ds.Tables[0];
                    return Dt;
                }
            }
            con_close();
            return null;
        }

        public void ExecuteNonQuery(string sql)
        {
            if (con_open())
            {
                using (Perintah = new MySqlCommand(sql, Koneksi))
                {
                    Perintah.ExecuteNonQuery();
                    Perintah.Dispose();
                    con_close();
                }
            }
        }
        public void Insert(string nama_table, string query, string isi=null)  // Created by Luthfi - Idea inspired by Code Ignitier
        {
            /* Menyiapkan string awal yang akan dipakai */
            string sql = "INSERT INTO " + nama_table + " ( " ;
            string values = "";       
           // string param = "";

            string[] rows = query.Split(','); //Parsing query, membagi query menjadi array-array yang dibatasi oleh tanda kome

            for (int i = 0; i < rows.Count(); i++) // Perulangan array, menghasilkan array nama field dan value nya
            {
                string field = rows[i];        // Meng assign array
                string[] fields = field.Split('='); //Passing query lagi, disini array akan dibatasi oleh tanda sama dengan
                for (int j = 0; j < fields.Count(); j++)
                {
                    if (j % 2 == 0)  //Jika hasil modulus j dengan 2 sama dengan 0 maka
                    {
                        sql += fields[j] + ","; //Nama field database yang akan dimasukkan ke variabel string sql  
                       //param += "@" + fields[j] + ",";
                    }
                    else
                    {                        
                        values += fields[j] + ","; //Isinya (value) yang akan dimasukkan ke variable values
                    }
                }
            }
            sql = sql.Remove(sql.Length - 1, 1); //Menghapus tanda koma diakhir
            sql += " )"; //Diganti dengan tutup kurung

            values= values.Remove(values.Length - 1, 1);
            values += " )";
          //  string satauan = "" + "@satuan" + "";
            try {
                if (con_open()) //Jika koneksi berhasil maka =
                {
                    using (Perintah = new MySqlCommand(sql + " VALUES (" + values, Koneksi)) //Menyimpan ke dalam database menggunakan query yang tadi sudah dihasilkan
                   // using (Perintah = new MySqlCommand("INSERT INTO tbl_satuan(satuan) VALUES (@satuan)", Koneksi))//Menyimpan ke dalam database menggunakan query yang tadi sudah dihasilkan
                    {
                        Perintah.ExecuteNonQuery();
                        Perintah.Dispose();
                        con_close();
                    }
                    //return "INSERT INTO " + nama_table + " ( " + sql + " VALUES ( " + param + values.Replace("'", "").Remove(values.Length - 1, 1);               
                }
            } catch(MySqlException ex)
            {
                MessageBox.Show(sql + " VALUES (" + values);
                MessageBox.Show(ex.ToString());
            }          
        }

        public void Update(string nama_table, string query, string primaryKey)  // Created by Luthfi - Idea inspired by Code Ignitier
        {
            /* Menyiapkan string awal yang akan dipakai */
            string sql = "UPDATE " + nama_table + " SET  ";
            string pk = " WHERE ";

            string[] pks = primaryKey.Split('=');
            for(int h = 0; h < pks.Count(); h++)
            {
                if(h % 2 == 0)
                {
                    pk +=  pks[h];
                }
                else
                {
                    pk += "=" + pks[h];
                }
            }

            if (con_open()) //Jika koneksi berhasil maka =
            {
                string[] rows = query.Split(','); //Parsing query, membagi query menjadi array-array yang dibatasi oleh tanda kome

                for (int i = 0; i < rows.Count(); i++) // Perulangan array, menghasilkan array nama field dan value nya
                {
                    string field = rows[i];        // Meng assign array
                    string[] fields = field.Split('='); //Passing query lagi, disini array akan dibatasi oleh tanda sama dengan
                    for (int j = 0; j < fields.Count(); j++)
                    {
                        if (j % 2 == 0)  //Jika hasil modulus j dengan 2 sama dengan 0 maka
                        {
                            sql +=  fields[j] + "="; //Nama field database yang akan dimasukkan ke variabel string sql
                        }
                        else
                        {
                            sql += fields[j] + ","; //Isinya (value) yang akan dimasukkan ke variable values
                        }
                    }
                }
                sql = sql.Remove(sql.Length - 1, 1); //Menghapus tanda koma diakhir
                                                     // sql += " )"; //Diganti dengan tutup kurung
                using (Perintah = new MySqlCommand(sql + pk, Koneksi)) //Menyimpan ke dalam database menggunakan query yang tadi sudah dihasilkan
                {
                    //Koneksi.Open();

                    Perintah.ExecuteNonQuery();

                    Perintah.Dispose();
                    con_close();
                }
              //  return sql +pk;
            }
            //return sql+pk;
        }

        public void Delete(string nama_table, string primaryKey)
        {
            string sql = "DELETE FROM " + nama_table + " WHERE ";
            string pk = null;
            string value = null;

           
            string[] fields = primaryKey.Split('=');
            for (byte j = 0; j < fields.Count(); j++)
            {
                if (j % 2 == 0)
                {
                    sql += fields[j] + " =";
                    pk += "?" + fields[j];
                }
                else
                {
                    value +=  fields[j];
                }
            }

            value = value.Replace("'", "");
           // return sql + pk + value;
            if (con_open())
            {
                using (Perintah = new MySqlCommand(sql + pk, Koneksi)) //Menyimpan ke dalam database menggunakan query yang tadi sudah dihasilkan
                {                    
                    pk = pk.Remove(pk.Length - 1, 1);
                    Perintah.Parameters.Clear();
                    Perintah.Parameters.AddWithValue(pk, value);
                    Perintah.ExecuteNonQuery();

                    Perintah.Dispose();
                    con_close();
                }             
            }
        }
       
    }
}
