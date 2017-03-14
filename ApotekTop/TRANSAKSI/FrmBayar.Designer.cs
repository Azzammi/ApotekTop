namespace ApotekTop.TRANSAKSI
{
    partial class FrmBayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBayar));
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalHargaTXT = new System.Windows.Forms.NumericUpDown();
            this.diskonTXT = new System.Windows.Forms.NumericUpDown();
            this.totalTXT = new System.Windows.Forms.NumericUpDown();
            this.sisaTXT = new System.Windows.Forms.NumericUpDown();
            this.bayarTXT = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tempoDT = new System.Windows.Forms.DateTimePicker();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalHargaTXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskonTXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisaTXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayarTXT)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(114, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "Rp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Total Kotor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Diskon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(114, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Rp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 71;
            this.label7.Text = "Total Bersih";
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
            this.toolStrip.Location = new System.Drawing.Point(0, 227);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(409, 42);
            this.toolStrip.TabIndex = 73;
            this.toolStrip.TabStop = true;
            this.toolStrip.Text = "ToolStrip";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = global::ApotekTop.Properties.Resources.Receipt_96px;
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Black;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 39);
            this.SaveBtn.Text = "Checkout";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(114, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Rp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 75;
            this.label10.Text = "Bayar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(114, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 79;
            this.label11.Text = "Rp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 78;
            this.label12.Text = "Sisa / Kembali";
            // 
            // totalHargaTXT
            // 
            this.totalHargaTXT.BackColor = System.Drawing.Color.White;
            this.totalHargaTXT.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHargaTXT.ForeColor = System.Drawing.Color.Black;
            this.totalHargaTXT.Location = new System.Drawing.Point(144, 72);
            this.totalHargaTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.totalHargaTXT.Name = "totalHargaTXT";
            this.totalHargaTXT.Size = new System.Drawing.Size(248, 29);
            this.totalHargaTXT.TabIndex = 83;
            this.totalHargaTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalHargaTXT.ThousandsSeparator = true;
            this.totalHargaTXT.ValueChanged += new System.EventHandler(this.totalHargaTXT_ValueChanged);
            this.totalHargaTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // diskonTXT
            // 
            this.diskonTXT.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskonTXT.Location = new System.Drawing.Point(115, 41);
            this.diskonTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.diskonTXT.Name = "diskonTXT";
            this.diskonTXT.Size = new System.Drawing.Size(277, 25);
            this.diskonTXT.TabIndex = 81;
            this.diskonTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diskonTXT.ThousandsSeparator = true;
            this.diskonTXT.ValueChanged += new System.EventHandler(this.diskonTXT_ValueChanged);
            this.diskonTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // totalTXT
            // 
            this.totalTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(48)))));
            this.totalTXT.Enabled = false;
            this.totalTXT.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTXT.Location = new System.Drawing.Point(142, 12);
            this.totalTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.totalTXT.Name = "totalTXT";
            this.totalTXT.ReadOnly = true;
            this.totalTXT.Size = new System.Drawing.Size(250, 25);
            this.totalTXT.TabIndex = 80;
            this.totalTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalTXT.ThousandsSeparator = true;
            this.totalTXT.ValueChanged += new System.EventHandler(this.totalTXT_ValueChanged);
            this.totalTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // sisaTXT
            // 
            this.sisaTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(48)))));
            this.sisaTXT.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sisaTXT.ForeColor = System.Drawing.Color.White;
            this.sisaTXT.Location = new System.Drawing.Point(144, 142);
            this.sisaTXT.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.sisaTXT.Minimum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            -2147483648});
            this.sisaTXT.Name = "sisaTXT";
            this.sisaTXT.Size = new System.Drawing.Size(248, 29);
            this.sisaTXT.TabIndex = 84;
            this.sisaTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sisaTXT.ThousandsSeparator = true;
            this.sisaTXT.ValueChanged += new System.EventHandler(this.sisaTXT_ValueChanged);
            this.sisaTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // bayarTXT
            // 
            this.bayarTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(175)))), ((int)(((byte)(14)))));
            this.bayarTXT.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayarTXT.ForeColor = System.Drawing.Color.White;
            this.bayarTXT.Location = new System.Drawing.Point(144, 107);
            this.bayarTXT.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.bayarTXT.Name = "bayarTXT";
            this.bayarTXT.Size = new System.Drawing.Size(248, 29);
            this.bayarTXT.TabIndex = 85;
            this.bayarTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bayarTXT.ThousandsSeparator = true;
            this.bayarTXT.ValueChanged += new System.EventHandler(this.bayarTXT_ValueChanged);
            this.bayarTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(130, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Akan membayar sisanya pada tanggal ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempoDT
            // 
            this.tempoDT.CustomFormat = "dddd ddMMMMyyyy";
            this.tempoDT.Enabled = false;
            this.tempoDT.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tempoDT.Location = new System.Drawing.Point(117, 193);
            this.tempoDT.Name = "tempoDT";
            this.tempoDT.Size = new System.Drawing.Size(275, 25);
            this.tempoDT.TabIndex = 87;
            this.tempoDT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // FrmBayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(409, 269);
            this.Controls.Add(this.tempoDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bayarTXT);
            this.Controls.Add(this.sisaTXT);
            this.Controls.Add(this.totalHargaTXT);
            this.Controls.Add(this.diskonTXT);
            this.Controls.Add(this.totalTXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bayar";
            this.Load += new System.EventHandler(this.FrmBayar_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalHargaTXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskonTXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisaTXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayarTXT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown totalHargaTXT;
        public System.Windows.Forms.NumericUpDown diskonTXT;
        public System.Windows.Forms.NumericUpDown totalTXT;
        public System.Windows.Forms.NumericUpDown sisaTXT;
        public System.Windows.Forms.NumericUpDown bayarTXT;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker tempoDT;
    }
}