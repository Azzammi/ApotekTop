using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ApotekTop
{
    class ClsControl : ClsKoneksi
    {
        public void EmptyText(Form namaForm, ComboBox cbx=null)
        {
            if(cbx != null)
            {
               foreach(Control i in cbx.Controls)
                {
                    if (i is TextBox) { i.Text = null; }
                    if (i is ComboBox) { i.Text = null; }
                }
            }
          
            foreach (Control i in namaForm.Controls)
            {
                if (i is TextBox) { i.Text = null; }
                if (i is ComboBox) { i.Text = null; }
            }
        }

        public void AutoNUmberRows(DataGridView DG)
        {
            if(DG != null)
            {
                int COT = 0;
                while(COT <= (DG.Rows.Count - 1))
                {
                    DG.Rows[COT].HeaderCell.Value = String.Format((COT + 1).ToString(), "0");
                    COT += 1;
                }

                COT = 0;
            }
        }

        public string GenerateNumber(string namaTabel, string namaField)
        {
            //ClsKoneksi koneksi = new ClsKoneksi();          
            if(con_open())
            {
                string number;
                using (Perintah = new MySqlCommand("SELECT " + namaField + " FROM " + namaTabel + " order by " + namaField + " DESC",Koneksi))
                {                    
                    RaDa = Perintah.ExecuteReader();
                    RaDa.Read();
                    if (RaDa.HasRows)
                    {
                        number = RaDa["" + namaField + ""].ToString();
                        number = number.Substring(number.Length - 6, 6);
                        int num = int.Parse(number) + 1;
                        
                        RaDa.Close();
                        con_close();

                        return num.ToString();                        
                    }
                    else
                    {
                        RaDa.Close();
                        con_close();

                        return "100001";
                    }                    
                }                              
            }
            return "False";
        }

    }
}
