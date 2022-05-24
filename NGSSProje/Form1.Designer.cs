
namespace NGSSProje
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChcUyelik = new System.Windows.Forms.CheckBox();
            this.DtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbKart = new System.Windows.Forms.ComboBox();
            this.ChcTelefon = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart Varsa Tipini Seçiniz:";
            // 
            // ChcUyelik
            // 
            this.ChcUyelik.AutoSize = true;
            this.ChcUyelik.Location = new System.Drawing.Point(112, 155);
            this.ChcUyelik.Name = "ChcUyelik";
            this.ChcUyelik.Size = new System.Drawing.Size(319, 29);
            this.ChcUyelik.TabIndex = 3;
            this.ChcUyelik.Text = "Mağaza Üyeliğiniz Varsa Seçiniz";
            this.ChcUyelik.UseVisualStyleBackColor = true;
            // 
            // DtpTarih
            // 
            this.DtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTarih.Location = new System.Drawing.Point(273, 244);
            this.DtpTarih.Name = "DtpTarih";
            this.DtpTarih.Size = new System.Drawing.Size(200, 30);
            this.DtpTarih.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Üyelik Tarihi:";
            // 
            // TxtFatura
            // 
            this.TxtFatura.Location = new System.Drawing.Point(273, 280);
            this.TxtFatura.Name = "TxtFatura";
            this.TxtFatura.Size = new System.Drawing.Size(146, 30);
            this.TxtFatura.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fatura Tutarı:";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(274, 330);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(199, 42);
            this.BtnHesapla.TabIndex = 6;
            this.BtnHesapla.Text = "HESAPLA";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Net Ödenecek Tutar:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(273, 398);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(146, 30);
            this.TxtTutar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(138, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 49);
            this.label2.TabIndex = 13;
            this.label2.Text = "FATURA HESAPLAMA";
            // 
            // CmbKart
            // 
            this.CmbKart.FormattingEnabled = true;
            this.CmbKart.Items.AddRange(new object[] {
            "ALTIN",
            "GÜMÜŞ"});
            this.CmbKart.Location = new System.Drawing.Point(274, 107);
            this.CmbKart.Name = "CmbKart";
            this.CmbKart.Size = new System.Drawing.Size(121, 33);
            this.CmbKart.TabIndex = 14;
            // 
            // ChcTelefon
            // 
            this.ChcTelefon.AutoSize = true;
            this.ChcTelefon.Location = new System.Drawing.Point(112, 199);
            this.ChcTelefon.Name = "ChcTelefon";
            this.ChcTelefon.Size = new System.Drawing.Size(268, 29);
            this.ChcTelefon.TabIndex = 15;
            this.ChcTelefon.Text = "Ürünlerde Telefon Var Mı ?";
            this.ChcTelefon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(710, 486);
            this.Controls.Add(this.ChcTelefon);
            this.Controls.Add(this.CmbKart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtpTarih);
            this.Controls.Add(this.ChcUyelik);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChcUyelik;
        private System.Windows.Forms.DateTimePicker DtpTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbKart;
        private System.Windows.Forms.CheckBox ChcTelefon;
    }
}

