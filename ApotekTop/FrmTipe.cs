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
    public partial class FrmTipe : Form
    {
        string primaryKey;
        bool isEdit;
        CRUD crud = new CRUD();
        ClsControl setControl = new ClsControl();

        public FrmTipe()
        {
            InitializeComponent();
            Pengaturan();
        }

        public string PrimaryKey
        {
            get { return this.primaryKey; }
            set { this.primaryKey = value;  }
        }

        public bool IsEdit
        {
            get { return this.isEdit; }
            set { this.isEdit = value; }
        }

        private void Pengaturan()
        {
            if (isEdit)
            {
                tipeTXT.Focus();
            }
            else
            {
                setControl.EmptyText(this);
                tipeTXT.Focus();
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                crud.Update("tbl_tipe", "tipe = '" + tipeTXT.Text + "', keterangan = '" + ketTXT.Text + "'", "id_tipe = '" + primaryKey + "'");
                this.Close();
            }
            else
            {
                crud.Insert("tbl_tipe", "tipe = '" + tipeTXT.Text + "', keterangan = '" + ketTXT.Text + "'");
            }
            isEdit = false;
            Pengaturan();
        }
    }
}
