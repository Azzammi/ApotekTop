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
    public partial class FrmSatuan : Form
    {
        bool isEdit;
        string primaryKey;
        CRUD crud = new CRUD();

        public FrmSatuan()
        {
            InitializeComponent();
            Pengaturan();
        }

        public string PrimaryKey
        {
            get { return this.primaryKey; }
            set { this.primaryKey = value;  }
        }
        public string NmSatuan
        {
            get { return this.satuanTxt.Text; }
            set { this.satuanTxt.Text = value; }
        }
        public bool IsEdit
        {
            get { return this.isEdit;  }
            set { this.isEdit = value; }
        }
        private void Pengaturan()
        {
            if (isEdit == false)
            {
                ClsControl setControl = new ClsControl();
                setControl.EmptyText(this);
                satuanTxt.Focus();
            }       
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {    
            if (isEdit)
            {
                crud.Update("tbl_satuan", " satuan = '" + satuanTxt.Text + "'", "id_satuan = '" + primaryKey + "'");
                this.Close();
            }
            else
            {
                crud.Insert("tbl_satuan", "satuan = '" + satuanTxt.Text + "'");
            }           
            IsEdit = false;
            Pengaturan();
        }

    }
}
