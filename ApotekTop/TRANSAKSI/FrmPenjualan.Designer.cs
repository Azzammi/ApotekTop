namespace ApotekTop.TRANSAKSI
{
    partial class FrmPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPenjualan));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.batalBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.editBtn = new System.Windows.Forms.ToolStripButton();
            this.tambahBtn = new System.Windows.Forms.ToolStripButton();
            this.bayarBtn = new System.Windows.Forms.ToolStripButton();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.labelTS = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.totalLbl = new System.Windows.Forms.ToolStripLabel();
            this.rplLbl = new System.Windows.Forms.ToolStripLabel();
            this.merekTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmObatTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noFakturTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.expiredDT = new System.Windows.Forms.DateTimePicker();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label11 = new System.Windows.Forms.Label();
            this.nmKonsumenTXT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ketTXT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hargaSatuanTXT = new System.Windows.Forms.NumericUpDown();
            this.subTotalTXT = new System.Windows.Forms.NumericUpDown();
            this.qtyTXT = new System.Windows.Forms.NumericUpDown();
            this.diskonTXT = new System.Windows.Forms.NumericUpDown();
            this.kdObatTXT = new System.Windows.Forms.TextBox();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hargaSatuanTXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTotalTXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyTXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskonTXT)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batalBtn,
            this.toolStripSeparator1,
            this.deleteBtn,
            this.editBtn,
            this.tambahBtn,
            this.bayarBtn,
            this.progressBar,
            this.labelTS});
            this.toolStrip2.Location = new System.Drawing.Point(0, 465);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1058, 32);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.TabStop = true;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // batalBtn
            // 
            this.batalBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.batalBtn.Image = global::ApotekTop.Properties.Resources.Close_Window_96px;
            this.batalBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(61, 29);
            this.batalBtn.Text = "Batal";
            this.batalBtn.ToolTipText = "Batal";
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deleteBtn.Image = global::ApotekTop.Properties.Resources.Delete_50px;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(69, 29);
            this.deleteBtn.Text = "Hapus";
            this.deleteBtn.ToolTipText = "Hapus";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.editBtn.Enabled = false;
            this.editBtn.Image = global::ApotekTop.Properties.Resources.Pencil_Tip_50px;
            this.editBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(55, 29);
            this.editBtn.Text = "Edit";
            this.editBtn.ToolTipText = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tambahBtn.Image = global::ApotekTop.Properties.Resources.Add_50px;
            this.tambahBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(79, 29);
            this.tambahBtn.Text = "Tambah";
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // bayarBtn
            // 
            this.bayarBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bayarBtn.Image = global::ApotekTop.Properties.Resources.Paid_96px;
            this.bayarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bayarBtn.Name = "bayarBtn";
            this.bayarBtn.Size = new System.Drawing.Size(64, 29);
            this.bayarBtn.Text = "Bayar";
            this.bayarBtn.ToolTipText = "Bayar";
            this.bayarBtn.Click += new System.EventHandler(this.bayarBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 29);
            // 
            // labelTS
            // 
            this.labelTS.Name = "labelTS";
            this.labelTS.Size = new System.Drawing.Size(45, 29);
            this.labelTS.Text = "labelTS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 259);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.totalLbl,
            this.rplLbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1058, 66);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = global::ApotekTop.Properties.Resources.Bank_96px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(292, 63);
            this.toolStripButton1.Text = "Transaksi Penjualan";
            this.toolStripButton1.ToolTipText = "Transaksi";
            // 
            // totalLbl
            // 
            this.totalLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.Lime;
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(51, 63);
            this.totalLbl.Text = "0";
            // 
            // rplLbl
            // 
            this.rplLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rplLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rplLbl.ForeColor = System.Drawing.Color.Lime;
            this.rplLbl.Name = "rplLbl";
            this.rplLbl.Size = new System.Drawing.Size(86, 63);
            this.rplLbl.Text = "Rp";
            // 
            // merekTXT
            // 
            this.merekTXT.Enabled = false;
            this.merekTXT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merekTXT.Location = new System.Drawing.Point(200, 110);
            this.merekTXT.Name = "merekTXT";
            this.merekTXT.Size = new System.Drawing.Size(134, 23);
            this.merekTXT.TabIndex = 2;
            this.merekTXT.Text = "test";
            this.merekTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nama Obat";
            // 
            // nmObatTXT
            // 
            this.nmObatTXT.Enabled = false;
            this.nmObatTXT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmObatTXT.Location = new System.Drawing.Point(97, 140);
            this.nmObatTXT.Name = "nmObatTXT";
            this.nmObatTXT.Size = new System.Drawing.Size(277, 23);
            this.nmObatTXT.TabIndex = 4;
            this.nmObatTXT.Text = "test";
            this.nmObatTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kode Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "No. Faktur";
            // 
            // noFakturTXT
            // 
            this.noFakturTXT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noFakturTXT.Location = new System.Drawing.Point(97, 80);
            this.noFakturTXT.Name = "noFakturTXT";
            this.noFakturTXT.ReadOnly = true;
            this.noFakturTXT.Size = new System.Drawing.Size(277, 27);
            this.noFakturTXT.TabIndex = 0;
            this.noFakturTXT.Text = "test";
            this.noFakturTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Expired";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Diskon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Harga Satuan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Sub Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(482, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Rp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(482, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Rp";
            // 
            // browseBtn
            // 
            this.browseBtn.Image = global::ApotekTop.Properties.Resources.Google_Web_Search_50px;
            this.browseBtn.Location = new System.Drawing.Point(340, 110);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(33, 24);
            this.browseBtn.TabIndex = 3;
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // expiredDT
            // 
            this.expiredDT.CustomFormat = "dddd ddMMMMyyyy";
            this.expiredDT.Enabled = false;
            this.expiredDT.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiredDT.Location = new System.Drawing.Point(97, 167);
            this.expiredDT.Name = "expiredDT";
            this.expiredDT.Size = new System.Drawing.Size(277, 25);
            this.expiredDT.TabIndex = 5;
            this.expiredDT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(768, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nama Konsumen";
            // 
            // nmKonsumenTXT
            // 
            this.nmKonsumenTXT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmKonsumenTXT.Location = new System.Drawing.Point(771, 96);
            this.nmKonsumenTXT.Name = "nmKonsumenTXT";
            this.nmKonsumenTXT.Size = new System.Drawing.Size(234, 23);
            this.nmKonsumenTXT.TabIndex = 11;
            this.nmKonsumenTXT.Text = "test";
            this.nmKonsumenTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(768, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Keterangan";
            // 
            // ketTXT
            // 
            this.ketTXT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketTXT.Location = new System.Drawing.Point(771, 141);
            this.ketTXT.Multiline = true;
            this.ketTXT.Name = "ketTXT";
            this.ketTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ketTXT.Size = new System.Drawing.Size(285, 56);
            this.ketTXT.TabIndex = 13;
            this.ketTXT.Text = "test";
            this.ketTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.subTotalTXT_KeyDown);
            this.ketTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(1017, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 35);
            this.panel1.TabIndex = 47;
            // 
            // hargaSatuanTXT
            // 
            this.hargaSatuanTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(48)))));
            this.hargaSatuanTXT.Enabled = false;
            this.hargaSatuanTXT.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaSatuanTXT.Location = new System.Drawing.Point(512, 80);
            this.hargaSatuanTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.hargaSatuanTXT.Name = "hargaSatuanTXT";
            this.hargaSatuanTXT.ReadOnly = true;
            this.hargaSatuanTXT.Size = new System.Drawing.Size(250, 25);
            this.hargaSatuanTXT.TabIndex = 6;
            this.hargaSatuanTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hargaSatuanTXT.ThousandsSeparator = true;
            this.hargaSatuanTXT.ValueChanged += new System.EventHandler(this.hargaSatuanTXT_TextChanged);
            // 
            // subTotalTXT
            // 
            this.subTotalTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(175)))), ((int)(((byte)(14)))));
            this.subTotalTXT.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTXT.ForeColor = System.Drawing.Color.White;
            this.subTotalTXT.Location = new System.Drawing.Point(512, 168);
            this.subTotalTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.subTotalTXT.Name = "subTotalTXT";
            this.subTotalTXT.Size = new System.Drawing.Size(250, 29);
            this.subTotalTXT.TabIndex = 9;
            this.subTotalTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.subTotalTXT.ThousandsSeparator = true;
            // 
            // qtyTXT
            // 
            this.qtyTXT.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTXT.Location = new System.Drawing.Point(485, 110);
            this.qtyTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.qtyTXT.Name = "qtyTXT";
            this.qtyTXT.Size = new System.Drawing.Size(277, 25);
            this.qtyTXT.TabIndex = 7;
            this.qtyTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qtyTXT.ThousandsSeparator = true;
            this.qtyTXT.ValueChanged += new System.EventHandler(this.qtyTXT_TextChanged);
            // 
            // diskonTXT
            // 
            this.diskonTXT.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskonTXT.Location = new System.Drawing.Point(485, 138);
            this.diskonTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.diskonTXT.Name = "diskonTXT";
            this.diskonTXT.Size = new System.Drawing.Size(277, 25);
            this.diskonTXT.TabIndex = 8;
            this.diskonTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diskonTXT.ThousandsSeparator = true;
            // 
            // kdObatTXT
            // 
            this.kdObatTXT.Enabled = false;
            this.kdObatTXT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kdObatTXT.Location = new System.Drawing.Point(97, 110);
            this.kdObatTXT.Name = "kdObatTXT";
            this.kdObatTXT.Size = new System.Drawing.Size(97, 23);
            this.kdObatTXT.TabIndex = 1;
            this.kdObatTXT.Text = "test";
            this.kdObatTXT.TextChanged += new System.EventHandler(this.kdObatTXT_TextChanged);
            this.kdObatTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // FrmPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 497);
            this.Controls.Add(this.kdObatTXT);
            this.Controls.Add(this.diskonTXT);
            this.Controls.Add(this.subTotalTXT);
            this.Controls.Add(this.qtyTXT);
            this.Controls.Add(this.hargaSatuanTXT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ketTXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nmKonsumenTXT);
            this.Controls.Add(this.expiredDT);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.merekTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmObatTXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noFakturTXT);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPenjualan";
            this.Text = "Penjualan";
            this.Load += new System.EventHandler(this.FrmPenjualan_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hargaSatuanTXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTotalTXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyTXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskonTXT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton batalBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripButton editBtn;
        private System.Windows.Forms.ToolStripButton bayarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel rplLbl;
        private System.Windows.Forms.ToolStripLabel totalLbl;
        private System.Windows.Forms.TextBox merekTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nmObatTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noFakturTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button browseBtn;
        public System.Windows.Forms.DateTimePicker expiredDT;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripLabel labelTS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ketTXT;
        private System.Windows.Forms.TextBox nmKonsumenTXT;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown hargaSatuanTXT;
        public System.Windows.Forms.NumericUpDown subTotalTXT;
        public System.Windows.Forms.NumericUpDown qtyTXT;
        public System.Windows.Forms.NumericUpDown diskonTXT;
        private System.Windows.Forms.ToolStripButton tambahBtn;
        private System.Windows.Forms.TextBox kdObatTXT;
    }
}