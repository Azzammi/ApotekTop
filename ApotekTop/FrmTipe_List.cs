using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekTop
{
    public partial class FrmTipe_List : Form
    {
        CRUD crud = new CRUD();
        SetDataGrid setCGrid = new SetDataGrid();
        string valueFromDG;

        public FrmTipe_List()
        {
            InitializeComponent();
            recordLoad();
        }

        private void recordLoad()
        {
            crud.Dt = crud.Select("tbl_tipe", "id_tipe,tipe,keterangan");
            dataGridView1.DataSource = crud.Dt;
            setCGrid.CreateHeader(dataGridView1, 2, "ID Tipe, Tipe, Keterangan", "75,100,168"); 
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            using (FrmTipe frmTipe = new FrmTipe())
            {
                frmTipe.IsEdit = false;
                frmTipe.ShowDialog();
            }
            recordLoad();
        }            

        private void editBtn_Click(object sender, EventArgs e)
        {
            using (FrmTipe frmTipe = new FrmTipe())
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    frmTipe.PrimaryKey = row.Cells[0].Value.ToString();
                }
                frmTipe.IsEdit = true;
                frmTipe.ShowDialog();
            }
            recordLoad();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            recordLoad();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus  ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    valueFromDG += row.Cells[0].Value + ",";
                }
                string[] valuesDG = valueFromDG.Split(',');

                for (byte i = 0; i < valuesDG.Count() - 1; i++)
                {                   
                    crud.Delete("tbl_tipe", "id_tipe ='" + valuesDG[i] + "'");                    
                }

                //MessageBox.Show(valueFromDG);
                valueFromDG = null;
                recordLoad();       
            }
        }
    }
}
