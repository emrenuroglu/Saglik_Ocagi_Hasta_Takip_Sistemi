namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    partial class taburcuForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnTaburcuet = new System.Windows.Forms.Button();
            this.cmbTaburcu = new System.Windows.Forms.ComboBox();
            this.txtYapılanislem = new System.Windows.Forms.TextBox();
            this.txtPoliklinik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTaburcuet);
            this.panel1.Controls.Add(this.cmbTaburcu);
            this.panel1.Controls.Add(this.txtYapılanislem);
            this.panel1.Controls.Add(this.txtPoliklinik);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(213, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 363);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "TABURCU GÜNCELLEME";
            // 
            // btnTaburcuet
            // 
            this.btnTaburcuet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaburcuet.Location = new System.Drawing.Point(130, 270);
            this.btnTaburcuet.Name = "btnTaburcuet";
            this.btnTaburcuet.Size = new System.Drawing.Size(174, 45);
            this.btnTaburcuet.TabIndex = 6;
            this.btnTaburcuet.Text = "TABURCU ET";
            this.btnTaburcuet.UseVisualStyleBackColor = true;
            this.btnTaburcuet.Click += new System.EventHandler(this.btnTaburcuet_Click_1);
            // 
            // cmbTaburcu
            // 
            this.cmbTaburcu.FormattingEnabled = true;
            this.cmbTaburcu.Items.AddRange(new object[] {
            "Taburcu Edildi",
            "Taburcu Edilmedi"});
            this.cmbTaburcu.Location = new System.Drawing.Point(226, 205);
            this.cmbTaburcu.Name = "cmbTaburcu";
            this.cmbTaburcu.Size = new System.Drawing.Size(153, 24);
            this.cmbTaburcu.TabIndex = 5;
            // 
            // txtYapılanislem
            // 
            this.txtYapılanislem.Location = new System.Drawing.Point(226, 157);
            this.txtYapılanislem.Name = "txtYapılanislem";
            this.txtYapılanislem.Size = new System.Drawing.Size(153, 22);
            this.txtYapılanislem.TabIndex = 4;
            // 
            // txtPoliklinik
            // 
            this.txtPoliklinik.Location = new System.Drawing.Point(226, 96);
            this.txtPoliklinik.Name = "txtPoliklinik";
            this.txtPoliklinik.Size = new System.Drawing.Size(153, 22);
            this.txtPoliklinik.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "TABURCU : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "YAPILAN İŞLEM : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "POLİKLİNİK : ";
            // 
            // taburcuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "taburcuForm";
            this.Text = "taburcuForm";
            this.Load += new System.EventHandler(this.taburcuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTaburcu;
        private System.Windows.Forms.TextBox txtYapılanislem;
        private System.Windows.Forms.TextBox txtPoliklinik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaburcuet;
    }
}