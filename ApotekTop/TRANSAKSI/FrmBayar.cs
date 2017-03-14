using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekTop.TRANSAKSI
{
    public partial class FrmBayar : Form
    {
        string no_faktur;
        ClsControl setControl = new ClsControl();
        public FrmBayar()
        {
            InitializeComponent();
        }

        public string NoFaktur
        {
            get { return this.no_faktur; }
            set { this.no_faktur = value; }
        }
        private void FrmBayar_Load(object sender, EventArgs e)
        {

        }

        private void totalTXT_ValueChanged(object sender, EventArgs e)
        {
            totalHargaTXT.Value = totalTXT.Value;
        }

        private void diskonTXT_ValueChanged(object sender, EventArgs e)
        {
            double diskon = Convert.ToDouble(diskonTXT.Value);
            diskon = Convert.ToDouble(totalTXT.Value) * diskon / 100;
            totalHargaTXT.Value = totalTXT.Value + Convert.ToDecimal(diskon);
        }

        private void totalHargaTXT_ValueChanged(object sender, EventArgs e)
        {
            sisaTXT.Value = 0 - totalHargaTXT.Value;
        }

        private void bayarTXT_ValueChanged(object sender, EventArgs e)
        {
            decimal sisa = sisaTXT.Value;
            sisaTXT.Value = sisa + bayarTXT.Value;
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(totalTXT.Value != 0 && sisaTXT.Value != 0)
            {
                CRUD crud = new CRUD();                
                if(sisaTXT.Value < -1)
                {
                    crud.Insert("tbl_detail_penjualan", "no_faktur = '" + no_faktur + "'," +
                                                                        "tgl_transaksi = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                                        "total = '" + totalTXT.Value + "'," +
                                                                        "diskon = '" + diskonTXT.Value + "'," +
                                                                        "total_harga = '" + totalHargaTXT.Value + "'," +
                                                                        "bayar = '" + bayarTXT.Value + "'," +
                                                                        "total_sisa = '" + sisaTXT.Value + "'," +
                                                                        "tgl_tempo = '" + tempoDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                }
                else
                {
                    crud.Insert("tbl_detail_penjualan", "no_faktur = '" + no_faktur + "'," +
                                                   "tgl_transaksi = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                   "total = '" + totalTXT.Value + "'," +
                                                   "diskon = '" + diskonTXT.Value + "'," +
                                                   "total_harga = '" + totalHargaTXT.Value + "'," +
                                                   "bayar = '" + bayarTXT.Value + "'," +
                                                   "kembali = '" + sisaTXT.Value + "'");                                                  
                }
                setControl.EmptyText(this);
                this.Close();
            }
        }

        private void sisaTXT_ValueChanged(object sender, EventArgs e)
        {
            if(sisaTXT.Value >= 0)
            {
                tempoDT.Enabled = false;
            }
            else
            {
                tempoDT.Enabled = true;
            }
        }
    }
}
