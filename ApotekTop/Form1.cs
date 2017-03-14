using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ApotekTop
{
    public partial class Form1 : Form 
    {
        CRUD crud = new CRUD();
        private const int totalRecords = 43;
        private const int pageSize = 10;

        public Form1()
        {
            InitializeComponent();
           // dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Index" });
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            //bindingSource1.DataSource = new PageOffsetList();
            bindingSource1.DataSource = crud.Select("kia_klasifikasi", "*");
        }

        private void refreshGrid()
        {
            CRUD crud = new CRUD();
            dataGridView1.DataSource  = crud.Select("table_admin", "*");
        } 
        

        private void button1_Click(object sender, EventArgs e)
        {
            //CRUD crud = new CRUD();
            // dataGridView1.DataSource =  crud.Select("table_admin", "*");
            int count = 0;
            string sql = "INSERT INTO TABLE ( ";
            string values = "( ";

            string kalimat = "kalimat = 'mantap', kata = greget ";
            string[] kalimats = kalimat.Split(',');

            int jumlah_field = kalimats.Count();

            for (int i = 0; i < jumlah_field; i++)
            {
                string field = kalimats[i];
                string[] fields = field.Split('=');
                //for (int j = 0; i < 2; j++) {
                foreach(string s in fields)
                {
                    count += 1;
                    if(count % 2 == 0)
                    {
                        values += s + ",";                        
                    } 
                   
                    else if(count % 2 == 1)
                    {
                       sql += s + ",";
                    }                   
                }                    
            }

            /* String.Right */
            /*string somestring = "ABCDEFG";
            string newstring = somestring.Substring(somestring.Length - 3, 3); */
            
            values = values.Remove(values.Length - 1, 1);
            values += " )";
            MessageBox.Show(sql+values);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            //crud.Insert("table_admin", "username = 'kamigata', password = 'kagami'");
            ////MessageBox.Show(crud.Update("table_admin", "password = 'luthfi'", "username = 'kamigata'"));
            //// MessageBox.Show(crud.Delete("table_admin", "username = 'kamigata'"));
            //refreshGrid();
            using(crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO tbl_obat (id_obat, nama_obat) VALUES(@id,@nama)",crud.Koneksi)){
                crud.Perintah.CommandType = CommandType.Text;
                crud.Perintah.Parameters.Clear();

                crud.Perintah.Parameters.AddWithValue("@id", "100004");
                crud.Perintah.Parameters.AddWithValue("@kode", "Luytf");
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            //textBox1.Text =  crud.Update("table_admin", "password = 'luthfi'", "username = 'kamigata'");
            refreshGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.Delete("table_admin", "username = 'kamigata'");
            refreshGrid();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            if (bindingSource1.Current == null)
            {
                dataGridView1.DataSource = bindingSource1;
            }else
            {
                dataGridView1.DataSource = crud.Select("kia_klasifikasi", "*");
            }
            //int offset = (int)bindingSource1.Current;
            //int offset = 1;
            //var records = new List<Record>();
            //for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
            //    records.Add(new Record { Index = i });
            //dataGridView1.DataSource = records;
        }

        class Record
        {
            public int Index { get; set; }
        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }
    }
}

