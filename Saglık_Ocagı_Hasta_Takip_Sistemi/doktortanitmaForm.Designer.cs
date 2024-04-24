namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    partial class doktortanitmaForm
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
            this.txtDrAdı = new System.Windows.Forms.TextBox();
            this.txtDrKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDrSoyadı = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDrAdı
            // 
            this.txtDrAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDrAdı.Location = new System.Drawing.Point(280, 60);
            this.txtDrAdı.Name = "txtDrAdı";
            this.txtDrAdı.Size = new System.Drawing.Size(238, 30);
            this.txtDrAdı.TabIndex = 10;
            // 
            // txtDrKodu
            // 
            this.txtDrKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDrKodu.Location = new System.Drawing.Point(280, 19);
            this.txtDrKodu.Name = "txtDrKodu";
            this.txtDrKodu.Size = new System.Drawing.Size(238, 30);
            this.txtDrKodu.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "DOKTOR ADI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOKTOR KODU : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "DOKTOR SOYADI :";
            // 
            // txtDrSoyadı
            // 
            this.txtDrSoyadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDrSoyadı.Location = new System.Drawing.Point(280, 99);
            this.txtDrSoyadı.Name = "txtDrSoyadı";
            this.txtDrSoyadı.Size = new System.Drawing.Size(238, 30);
            this.txtDrSoyadı.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtDrAdı);
            this.panel1.Controls.Add(this.txtDrSoyadı);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDrKodu);
            this.panel1.Location = new System.Drawing.Point(102, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 215);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 65);
            this.button1.TabIndex = 13;
            this.button1.Text = "GÖRÜNTÜLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGeri.Location = new System.Drawing.Point(447, 145);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(96, 62);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // doktortanitmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "doktortanitmaForm";
            this.Text = "doktortanitmaForm";
            this.Load += new System.EventHandler(this.doktortanitmaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDrAdı;
        private System.Windows.Forms.TextBox txtDrKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDrSoyadı;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGeri;
    }
}