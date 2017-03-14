namespace ApotekTop
{
    partial class FrmSatuan
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
            this.label2 = new System.Windows.Forms.Label();
            this.satuanTxt = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama Satuan";
            // 
            // satuanTxt
            // 
            this.satuanTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satuanTxt.Location = new System.Drawing.Point(127, 22);
            this.satuanTxt.Name = "satuanTxt";
            this.satuanTxt.Size = new System.Drawing.Size(277, 23);
            this.satuanTxt.TabIndex = 0;
            this.satuanTxt.Text = "test";
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
            this.toolStrip.Location = new System.Drawing.Point(0, 67);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(439, 42);
            this.toolStrip.TabIndex = 10;
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
            // FrmSatuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(439, 109);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.satuanTxt);
            this.Name = "FrmSatuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSatuan";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox satuanTxt;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton SaveBtn;
    }
}