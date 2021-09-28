
namespace Sustav_za_kriptiranje_i_dekriptiranje
{
    partial class FormKriptiranje
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
            this.txtRadniDirektorij = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdabirDirektorija = new System.Windows.Forms.Button();
            this.btnGeneriranjeKljuceva = new System.Windows.Forms.Button();
            this.btnIzracunavanjeSazetka = new System.Windows.Forms.Button();
            this.btnDigitalnoPotpisivanje = new System.Windows.Forms.Button();
            this.btnProvjeraPotpisa = new System.Windows.Forms.Button();
            this.btnUlaznaDatoteka = new System.Windows.Forms.Button();
            this.txtUlazniPodaci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimetricnoKriptiranje = new System.Windows.Forms.Button();
            this.btnSimetricnoDekriptiranje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAsimetricnoKriptiranje = new System.Windows.Forms.Button();
            this.btnAsimetricnoDekriptiranje = new System.Windows.Forms.Button();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRadniDirektorij
            // 
            this.txtRadniDirektorij.Location = new System.Drawing.Point(33, 30);
            this.txtRadniDirektorij.Name = "txtRadniDirektorij";
            this.txtRadniDirektorij.Size = new System.Drawing.Size(362, 20);
            this.txtRadniDirektorij.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radni direktorij";
            // 
            // btnOdabirDirektorija
            // 
            this.btnOdabirDirektorija.Location = new System.Drawing.Point(91, 56);
            this.btnOdabirDirektorija.Name = "btnOdabirDirektorija";
            this.btnOdabirDirektorija.Size = new System.Drawing.Size(249, 39);
            this.btnOdabirDirektorija.TabIndex = 2;
            this.btnOdabirDirektorija.Text = "Odabir radnog direktorija";
            this.btnOdabirDirektorija.UseVisualStyleBackColor = true;
            this.btnOdabirDirektorija.Click += new System.EventHandler(this.btnOdabirDirektorija_Click);
            // 
            // btnGeneriranjeKljuceva
            // 
            this.btnGeneriranjeKljuceva.Enabled = false;
            this.btnGeneriranjeKljuceva.Location = new System.Drawing.Point(91, 101);
            this.btnGeneriranjeKljuceva.Name = "btnGeneriranjeKljuceva";
            this.btnGeneriranjeKljuceva.Size = new System.Drawing.Size(249, 39);
            this.btnGeneriranjeKljuceva.TabIndex = 3;
            this.btnGeneriranjeKljuceva.Text = "Generiranje ključeva";
            this.btnGeneriranjeKljuceva.UseVisualStyleBackColor = true;
            this.btnGeneriranjeKljuceva.Click += new System.EventHandler(this.btnGeneriranjeKljuceva_Click);
            // 
            // btnIzracunavanjeSazetka
            // 
            this.btnIzracunavanjeSazetka.Enabled = false;
            this.btnIzracunavanjeSazetka.Location = new System.Drawing.Point(91, 560);
            this.btnIzracunavanjeSazetka.Name = "btnIzracunavanjeSazetka";
            this.btnIzracunavanjeSazetka.Size = new System.Drawing.Size(249, 39);
            this.btnIzracunavanjeSazetka.TabIndex = 4;
            this.btnIzracunavanjeSazetka.Text = "Izračunavanje sažetka";
            this.btnIzracunavanjeSazetka.UseVisualStyleBackColor = true;
            this.btnIzracunavanjeSazetka.Click += new System.EventHandler(this.btnIzracunavanjeSazetka_Click);
            // 
            // btnDigitalnoPotpisivanje
            // 
            this.btnDigitalnoPotpisivanje.Enabled = false;
            this.btnDigitalnoPotpisivanje.Location = new System.Drawing.Point(91, 605);
            this.btnDigitalnoPotpisivanje.Name = "btnDigitalnoPotpisivanje";
            this.btnDigitalnoPotpisivanje.Size = new System.Drawing.Size(249, 39);
            this.btnDigitalnoPotpisivanje.TabIndex = 5;
            this.btnDigitalnoPotpisivanje.Text = "Digitalno potpisivanje";
            this.btnDigitalnoPotpisivanje.UseVisualStyleBackColor = true;
            this.btnDigitalnoPotpisivanje.Click += new System.EventHandler(this.btnDigitalnoPotpisivanje_Click_1);
            // 
            // btnProvjeraPotpisa
            // 
            this.btnProvjeraPotpisa.Enabled = false;
            this.btnProvjeraPotpisa.Location = new System.Drawing.Point(91, 650);
            this.btnProvjeraPotpisa.Name = "btnProvjeraPotpisa";
            this.btnProvjeraPotpisa.Size = new System.Drawing.Size(249, 39);
            this.btnProvjeraPotpisa.TabIndex = 6;
            this.btnProvjeraPotpisa.Text = "Provjera digitalnog potpisa";
            this.btnProvjeraPotpisa.UseVisualStyleBackColor = true;
            this.btnProvjeraPotpisa.Click += new System.EventHandler(this.btnProvjeraPotpisa_Click);
            // 
            // btnUlaznaDatoteka
            // 
            this.btnUlaznaDatoteka.Enabled = false;
            this.btnUlaznaDatoteka.Location = new System.Drawing.Point(91, 146);
            this.btnUlaznaDatoteka.Name = "btnUlaznaDatoteka";
            this.btnUlaznaDatoteka.Size = new System.Drawing.Size(249, 39);
            this.btnUlaznaDatoteka.TabIndex = 7;
            this.btnUlaznaDatoteka.Text = "Odabir ulazne datoteke";
            this.btnUlaznaDatoteka.UseVisualStyleBackColor = true;
            this.btnUlaznaDatoteka.Click += new System.EventHandler(this.btnUlaznaDatoteka_Click);
            // 
            // txtUlazniPodaci
            // 
            this.txtUlazniPodaci.Location = new System.Drawing.Point(33, 208);
            this.txtUlazniPodaci.Multiline = true;
            this.txtUlazniPodaci.Name = "txtUlazniPodaci";
            this.txtUlazniPodaci.Size = new System.Drawing.Size(362, 78);
            this.txtUlazniPodaci.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ulazni podaci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Simetrično kriptiranje i dekriptiranje";
            // 
            // btnSimetricnoKriptiranje
            // 
            this.btnSimetricnoKriptiranje.Enabled = false;
            this.btnSimetricnoKriptiranje.Location = new System.Drawing.Point(88, 317);
            this.btnSimetricnoKriptiranje.Name = "btnSimetricnoKriptiranje";
            this.btnSimetricnoKriptiranje.Size = new System.Drawing.Size(96, 39);
            this.btnSimetricnoKriptiranje.TabIndex = 11;
            this.btnSimetricnoKriptiranje.Text = "Kriptiranje";
            this.btnSimetricnoKriptiranje.UseVisualStyleBackColor = true;
            this.btnSimetricnoKriptiranje.Click += new System.EventHandler(this.btnSimetricnoKriptiranje_Click);
            // 
            // btnSimetricnoDekriptiranje
            // 
            this.btnSimetricnoDekriptiranje.Enabled = false;
            this.btnSimetricnoDekriptiranje.Location = new System.Drawing.Point(224, 317);
            this.btnSimetricnoDekriptiranje.Name = "btnSimetricnoDekriptiranje";
            this.btnSimetricnoDekriptiranje.Size = new System.Drawing.Size(99, 39);
            this.btnSimetricnoDekriptiranje.TabIndex = 12;
            this.btnSimetricnoDekriptiranje.Text = "Dekriptiranje";
            this.btnSimetricnoDekriptiranje.UseVisualStyleBackColor = true;
            this.btnSimetricnoDekriptiranje.Click += new System.EventHandler(this.btnSimetricnoDekriptiranje_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Asimetrično kriptiranje i dekriptiranje";
            // 
            // btnAsimetricnoKriptiranje
            // 
            this.btnAsimetricnoKriptiranje.Enabled = false;
            this.btnAsimetricnoKriptiranje.Location = new System.Drawing.Point(88, 400);
            this.btnAsimetricnoKriptiranje.Name = "btnAsimetricnoKriptiranje";
            this.btnAsimetricnoKriptiranje.Size = new System.Drawing.Size(96, 39);
            this.btnAsimetricnoKriptiranje.TabIndex = 14;
            this.btnAsimetricnoKriptiranje.Text = "Kriptiranje";
            this.btnAsimetricnoKriptiranje.UseVisualStyleBackColor = true;
            this.btnAsimetricnoKriptiranje.Click += new System.EventHandler(this.btnAsimetricnoKriptiranje_Click_1);
            // 
            // btnAsimetricnoDekriptiranje
            // 
            this.btnAsimetricnoDekriptiranje.Enabled = false;
            this.btnAsimetricnoDekriptiranje.Location = new System.Drawing.Point(224, 400);
            this.btnAsimetricnoDekriptiranje.Name = "btnAsimetricnoDekriptiranje";
            this.btnAsimetricnoDekriptiranje.Size = new System.Drawing.Size(99, 39);
            this.btnAsimetricnoDekriptiranje.TabIndex = 15;
            this.btnAsimetricnoDekriptiranje.Text = "Dekriptiranje";
            this.btnAsimetricnoDekriptiranje.UseVisualStyleBackColor = true;
            this.btnAsimetricnoDekriptiranje.Click += new System.EventHandler(this.btnAsimetricnoDekriptiranje_Click_1);
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(170, 442);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(67, 13);
            this.lblPrivateKey.TabIndex = 16;
            this.lblPrivateKey.Text = "Privatni kljuc";
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(170, 481);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(55, 13);
            this.lblSecretKey.TabIndex = 17;
            this.lblSecretKey.Text = "Tajni kljuc";
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Location = new System.Drawing.Point(170, 520);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(57, 13);
            this.lblPublicKey.TabIndex = 18;
            this.lblPublicKey.Text = "Javni kljuc";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(33, 458);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(362, 20);
            this.txtPrivateKey.TabIndex = 19;
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(33, 497);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(362, 20);
            this.txtSecretKey.TabIndex = 20;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(33, 534);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(362, 20);
            this.txtPublicKey.TabIndex = 21;
            // 
            // FormKriptiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 697);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.lblPublicKey);
            this.Controls.Add(this.lblSecretKey);
            this.Controls.Add(this.lblPrivateKey);
            this.Controls.Add(this.btnAsimetricnoDekriptiranje);
            this.Controls.Add(this.btnAsimetricnoKriptiranje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSimetricnoDekriptiranje);
            this.Controls.Add(this.btnSimetricnoKriptiranje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUlazniPodaci);
            this.Controls.Add(this.btnUlaznaDatoteka);
            this.Controls.Add(this.btnProvjeraPotpisa);
            this.Controls.Add(this.btnDigitalnoPotpisivanje);
            this.Controls.Add(this.btnIzracunavanjeSazetka);
            this.Controls.Add(this.btnGeneriranjeKljuceva);
            this.Controls.Add(this.btnOdabirDirektorija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadniDirektorij);
            this.Name = "FormKriptiranje";
            this.Text = "Kriptiranje i dekriptiranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadniDirektorij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdabirDirektorija;
        private System.Windows.Forms.Button btnGeneriranjeKljuceva;
        private System.Windows.Forms.Button btnIzracunavanjeSazetka;
        private System.Windows.Forms.Button btnDigitalnoPotpisivanje;
        private System.Windows.Forms.Button btnProvjeraPotpisa;
        private System.Windows.Forms.Button btnUlaznaDatoteka;
        private System.Windows.Forms.TextBox txtUlazniPodaci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimetricnoKriptiranje;
        private System.Windows.Forms.Button btnSimetricnoDekriptiranje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAsimetricnoKriptiranje;
        private System.Windows.Forms.Button btnAsimetricnoDekriptiranje;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.Label lblSecretKey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.TextBox txtPublicKey;
    }
}

