namespace ApotekTop
{
    partial class FrmObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObat));
            this.kdObatTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmObatTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kategoriCBX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusResepCBX = new System.Windows.Forms.ComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.label14 = new System.Windows.Forms.Label();
            this.merekTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.keteranganTXT = new System.Windows.Forms.TextBox();
            this.tipeCBX = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.satuanJualCBX = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.satuanStockCBX = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hargaPokokTxt = new System.Windows.Forms.NumericUpDown();
            this.selisihTXT = new System.Windows.Forms.NumericUpDown();
            this.marginTxt = new System.Windows.Forms.NumericUpDown();
            this.hargaJualTxt = new System.Windows.Forms.NumericUpDown();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hargaPokokTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selisihTXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaJualTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // kdObatTxt
            // 
            this.kdObatTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kdObatTxt.Location = new System.Drawing.Point(144, 12);
            this.kdObatTxt.MaxLength = 20;
            this.kdObatTxt.Name = "kdObatTxt";
            this.kdObatTxt.Size = new System.Drawing.Size(319, 23);
            this.kdObatTxt.TabIndex = 0;
            this.kdObatTxt.Text = "test";
            this.kdObatTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kode Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Obat";
            // 
            // nmObatTxt
            // 
            this.nmObatTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmObatTxt.Location = new System.Drawing.Point(144, 70);
            this.nmObatTxt.MaxLength = 50;
            this.nmObatTxt.Name = "nmObatTxt";
            this.nmObatTxt.Size = new System.Drawing.Size(319, 23);
            this.nmObatTxt.TabIndex = 2;
            this.nmObatTxt.Text = "test";
            this.nmObatTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kategori";
            // 
            // kategoriCBX
            // 
            this.kategoriCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriCBX.FormattingEnabled = true;
            this.kategoriCBX.Items.AddRange(new object[] {
            "Ya",
            "TIdak"});
            this.kategoriCBX.Location = new System.Drawing.Point(144, 104);
            this.kategoriCBX.MaxLength = 15;
            this.kategoriCBX.Name = "kategoriCBX";
            this.kategoriCBX.Size = new System.Drawing.Size(319, 24);
            this.kategoriCBX.TabIndex = 3;
            this.kategoriCBX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Resep";
            // 
            // statusResepCBX
            // 
            this.statusResepCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusResepCBX.FormattingEnabled = true;
            this.statusResepCBX.Location = new System.Drawing.Point(376, 134);
            this.statusResepCBX.Name = "statusResepCBX";
            this.statusResepCBX.Size = new System.Drawing.Size(85, 24);
            this.statusResepCBX.TabIndex = 5;
            this.statusResepCBX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip.BackgroundImage = global::ApotekTop.Properties.Resources.bg_1;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 415);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(475, 42);
            this.toolStrip.TabIndex = 13;
            this.toolStrip.TabStop = true;
            this.toolStrip.Text = "ToolStrip";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = global::ApotekTop.Properties.Resources.Save_50px_1;
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Black;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(72, 39);
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(78, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Merek";
            // 
            // merekTxt
            // 
            this.merekTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merekTxt.Location = new System.Drawing.Point(144, 41);
            this.merekTxt.MaxLength = 50;
            this.merekTxt.Name = "merekTxt";
            this.merekTxt.Size = new System.Drawing.Size(319, 23);
            this.merekTxt.TabIndex = 1;
            this.merekTxt.Text = "test";
            this.merekTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(44, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Keterangan";
            // 
            // keteranganTXT
            // 
            this.keteranganTXT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keteranganTXT.Location = new System.Drawing.Point(144, 164);
            this.keteranganTXT.MaxLength = 100;
            this.keteranganTXT.Name = "keteranganTXT";
            this.keteranganTXT.Size = new System.Drawing.Size(319, 23);
            this.keteranganTXT.TabIndex = 6;
            this.keteranganTXT.Text = "test";
            this.keteranganTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // tipeCBX
            // 
            this.tipeCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipeCBX.FormattingEnabled = true;
            this.tipeCBX.Location = new System.Drawing.Point(144, 134);
            this.tipeCBX.MaxLength = 15;
            this.tipeCBX.Name = "tipeCBX";
            this.tipeCBX.Size = new System.Drawing.Size(173, 24);
            this.tipeCBX.TabIndex = 4;
            this.tipeCBX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(89, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Tipe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Selisih Satuan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = " Harga Jual";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(145, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Rp";
            // 
            // satuanJualCBX
            // 
            this.satuanJualCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satuanJualCBX.FormattingEnabled = true;
            this.satuanJualCBX.Location = new System.Drawing.Point(144, 282);
            this.satuanJualCBX.Name = "satuanJualCBX";
            this.satuanJualCBX.Size = new System.Drawing.Size(319, 24);
            this.satuanJualCBX.TabIndex = 9;
            this.satuanJualCBX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Margin Jual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = " Harga Pokok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Satuan Stock";
            // 
            // satuanStockCBX
            // 
            this.satuanStockCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satuanStockCBX.FormattingEnabled = true;
            this.satuanStockCBX.Location = new System.Drawing.Point(144, 225);
            this.satuanStockCBX.Name = "satuanStockCBX";
            this.satuanStockCBX.Size = new System.Drawing.Size(319, 24);
            this.satuanStockCBX.TabIndex = 7;
            this.satuanStockCBX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(143, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Satuan Jual";
            // 
            // hargaPokokTxt
            // 
            this.hargaPokokTxt.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaPokokTxt.Location = new System.Drawing.Point(173, 253);
            this.hargaPokokTxt.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.hargaPokokTxt.Name = "hargaPokokTxt";
            this.hargaPokokTxt.Size = new System.Drawing.Size(290, 25);
            this.hargaPokokTxt.TabIndex = 8;
            this.hargaPokokTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hargaPokokTxt.ThousandsSeparator = true;
            this.hargaPokokTxt.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.hargaPokokTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // selisihTXT
            // 
            this.selisihTXT.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selisihTXT.Location = new System.Drawing.Point(144, 312);
            this.selisihTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.selisihTXT.Name = "selisihTXT";
            this.selisihTXT.Size = new System.Drawing.Size(319, 25);
            this.selisihTXT.TabIndex = 10;
            this.selisihTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.selisihTXT.ThousandsSeparator = true;
            this.selisihTXT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selisihTXT.ValueChanged += new System.EventHandler(this.selisihTXT_TextChanged);
            this.selisihTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // marginTxt
            // 
            this.marginTxt.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marginTxt.Location = new System.Drawing.Point(144, 340);
            this.marginTxt.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.marginTxt.Name = "marginTxt";
            this.marginTxt.Size = new System.Drawing.Size(319, 25);
            this.marginTxt.TabIndex = 11;
            this.marginTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.marginTxt.ThousandsSeparator = true;
            this.marginTxt.ValueChanged += new System.EventHandler(this.marginTxt_TextChanged);
            this.marginTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // hargaJualTxt
            // 
            this.hargaJualTxt.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaJualTxt.Location = new System.Drawing.Point(173, 369);
            this.hargaJualTxt.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.hargaJualTxt.Name = "hargaJualTxt";
            this.hargaJualTxt.Size = new System.Drawing.Size(290, 25);
            this.hargaJualTxt.TabIndex = 12;
            this.hargaJualTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hargaJualTxt.ThousandsSeparator = true;
            this.hargaJualTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // FrmObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(475, 457);
            this.Controls.Add(this.hargaJualTxt);
            this.Controls.Add(this.marginTxt);
            this.Controls.Add(this.selisihTXT);
            this.Controls.Add(this.hargaPokokTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.satuanJualCBX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.satuanStockCBX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tipeCBX);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.keteranganTXT);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.merekTxt);
            this.Controls.Add(this.statusResepCBX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kategoriCBX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmObatTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kdObatTxt);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obat";
            this.Load += new System.EventHandler(this.FrmObat_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hargaPokokTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selisihTXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaJualTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.TextBox kdObatTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox nmObatTxt;
        public System.Windows.Forms.ComboBox kategoriCBX;
        public System.Windows.Forms.ComboBox statusResepCBX;
        public System.Windows.Forms.TextBox merekTxt;
        public System.Windows.Forms.TextBox keteranganTXT;
        public System.Windows.Forms.ComboBox tipeCBX;
        public System.Windows.Forms.ComboBox satuanJualCBX;
        public System.Windows.Forms.ComboBox satuanStockCBX;
        public System.Windows.Forms.NumericUpDown selisihTXT;
        public System.Windows.Forms.NumericUpDown marginTxt;
        public System.Windows.Forms.NumericUpDown hargaJualTxt;
        public System.Windows.Forms.NumericUpDown hargaPokokTxt;
    }
}