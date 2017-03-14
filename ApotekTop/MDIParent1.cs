using System;
using System.Reflection;
using System.Windows.Forms;

namespace ApotekTop
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {           
            InitializeComponent();
            this.Text = AssemblyProduct + string.Format(" Version: {0} ", AssemblyVersion);
            toolStripStatusLabel1.Text = AssemblyProduct + string.Format(" Version: {0} ", AssemblyVersion);
            homeBtn.PerformClick();
            //toolStripButton1_Click_1(homeBtn, );
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmObat_List childForm = new FrmObat_List();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmObat_List))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FrmObat_List();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void satuanBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmSatuan_List))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FrmSatuan_List();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void kategoriBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmKategori_List))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FrmKategori_List();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmHome))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FrmHome();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void laporanTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hargaJualBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(TRANSAKSI.FrmPenjualan))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new TRANSAKSI.FrmPenjualan();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }
        private void stockObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmStock_List))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FrmStock_List();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            stockObatToolStripMenuItem.PerformClick();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Database.FrmBackupDB frm = new Database.FrmBackupDB())
            {
                frm.ShowDialog();
            }
        }

        private void restoreDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Database.frmRestoreDB frm = new Database.frmRestoreDB())
            {
                frm.ShowDialog();
            }
        }

        private void settingKoneksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Database.frmSettingKoneksi frm = new Database.frmSettingKoneksi())
            {
                frm.ShowDialog();
            }
        }

        private void tipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmTipe_List))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new FrmTipe_List();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void tampilkanLprnBtn_Click(object sender, EventArgs e)
        {
            if(tampilkanLprnBtn.Checked == true)
            {
                tampilkanLprnBtn.Checked = false;
                toolStrip1.Visible = true;
                toolStrip2.Visible = false;
            }
            else
            {
                tampilkanLprnBtn.Checked = true;
                toolStrip1.Visible = false;
                toolStrip2.Visible = true;
            }
        }

        private void pembelianBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(TRANSAKSI.FrmPembelian))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new TRANSAKSI.FrmPembelian();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void tipeBtn_Click(object sender, EventArgs e)
        {
            tipeToolStripMenuItem.PerformClick();
        }

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            penjualanBtn.PerformClick();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pembelianBtn.PerformClick();
        }

        private void listObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listObatBtn.PerformClick();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kategoriBtn.PerformClick();
        }

        private void satuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satuanBtn.PerformClick();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmAbout about = new FrmAbout())
            {
                about.ShowDialog();
            }
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(SUPP.FrmSupp_List))
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = new SUPP.FrmSupp_List();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplierBtn.PerformClick();
        }

       
    }
}
