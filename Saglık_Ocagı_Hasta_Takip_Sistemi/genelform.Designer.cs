namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    partial class genelform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEFERANSLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hASTAKABULToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEFERANSLARToolStripMenuItem,
            this.hASTAKABULToolStripMenuItem,
            this.rAPORLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEFERANSLARToolStripMenuItem
            // 
            this.rEFERANSLARToolStripMenuItem.Name = "rEFERANSLARToolStripMenuItem";
            this.rEFERANSLARToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.rEFERANSLARToolStripMenuItem.Text = "REFERANSLAR";
            this.rEFERANSLARToolStripMenuItem.Click += new System.EventHandler(this.rEFERANSLARToolStripMenuItem_Click);
            // 
            // hASTAKABULToolStripMenuItem
            // 
            this.hASTAKABULToolStripMenuItem.Name = "hASTAKABULToolStripMenuItem";
            this.hASTAKABULToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.hASTAKABULToolStripMenuItem.Text = "HASTA KABUL ";
            this.hASTAKABULToolStripMenuItem.Click += new System.EventHandler(this.hASTAKABULToolStripMenuItem_Click);
            // 
            // rAPORLARToolStripMenuItem
            // 
            this.rAPORLARToolStripMenuItem.Name = "rAPORLARToolStripMenuItem";
            this.rAPORLARToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.rAPORLARToolStripMenuItem.Text = "RAPORLAR";
            this.rAPORLARToolStripMenuItem.Click += new System.EventHandler(this.rAPORLARToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // genelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "genelform";
            this.Text = "genelform";
            this.Load += new System.EventHandler(this.genelform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEFERANSLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hASTAKABULToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}