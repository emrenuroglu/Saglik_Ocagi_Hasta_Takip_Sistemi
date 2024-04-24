namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    partial class dosyaaramayardımıForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAramakriter = new System.Windows.Forms.TextBox();
            this.cmbAramakriteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAramakriter);
            this.panel1.Controls.Add(this.cmbAramakriteri);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(124, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 192);
            this.panel1.TabIndex = 0;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(460, 145);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // txtAramakriter
            // 
            this.txtAramakriter.Location = new System.Drawing.Point(414, 36);
            this.txtAramakriter.Name = "txtAramakriter";
            this.txtAramakriter.Size = new System.Drawing.Size(121, 22);
            this.txtAramakriter.TabIndex = 3;
            // 
            // cmbAramakriteri
            // 
            this.cmbAramakriteri.FormattingEnabled = true;
            this.cmbAramakriteri.Items.AddRange(new object[] {
            "ADI-SOYAD",
            "TELEFON NUMARASI",
            "E-MAİL"});
            this.cmbAramakriteri.Location = new System.Drawing.Point(245, 33);
            this.cmbAramakriteri.Name = "cmbAramakriteri";
            this.cmbAramakriteri.Size = new System.Drawing.Size(121, 24);
            this.cmbAramakriteri.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOSYA NUMARASI : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARAMA KRİTERİ";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(618, 307);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(80, 74);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dosyaaramayardımıForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel1);
            this.Name = "dosyaaramayardımıForm";
            this.Text = "dosyaaramayardımıForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAramakriter;
        private System.Windows.Forms.ComboBox cmbAramakriteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnBul;
    }
}