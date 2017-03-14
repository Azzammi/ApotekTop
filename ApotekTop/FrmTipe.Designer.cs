namespace ApotekTop
{
    partial class FrmTipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipe));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.label14 = new System.Windows.Forms.Label();
            this.ketTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipeTXT = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip.Location = new System.Drawing.Point(0, 142);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(388, 42);
            this.toolStrip.TabIndex = 33;
            this.toolStrip.TabStop = true;
            this.toolStrip.Text = "ToolStrip";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SaveBtn.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = global::ApotekTop.Properties.Resources.Save_50px_1;
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Black;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(76, 39);
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Keterangan";
            // 
            // ketTXT
            // 
            this.ketTXT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketTXT.Location = new System.Drawing.Point(129, 55);
            this.ketTXT.MaxLength = 250;
            this.ketTXT.Multiline = true;
            this.ketTXT.Name = "ketTXT";
            this.ketTXT.Size = new System.Drawing.Size(229, 73);
            this.ketTXT.TabIndex = 32;
            this.ketTXT.Text = "test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tipe Obat";
            // 
            // tipeTXT
            // 
            this.tipeTXT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipeTXT.Location = new System.Drawing.Point(129, 26);
            this.tipeTXT.MaxLength = 50;
            this.tipeTXT.Name = "tipeTXT";
            this.tipeTXT.Size = new System.Drawing.Size(229, 23);
            this.tipeTXT.TabIndex = 31;
            this.tipeTXT.Text = "test";
            // 
            // FrmTipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(388, 184);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ketTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipeTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipe";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox ketTXT;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tipeTXT;
    }
}