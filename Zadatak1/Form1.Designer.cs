
namespace Zadatak1
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
            this.lstListaRacunara = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtProcesor = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtMaticnaPloca = new System.Windows.Forms.TextBox();
            this.txtNapajanje = new System.Windows.Forms.TextBox();
            this.txtTipDiska = new System.Windows.Forms.TextBox();
            this.txtMemorijaDiska = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnDodajUListu = new System.Windows.Forms.Button();
            this.btnUpali = new System.Windows.Forms.Button();
            this.btnDostavi = new System.Windows.Forms.Button();
            this.btnUgasi = new System.Windows.Forms.Button();
            this.btnUnosTeksta = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.btnProgrmiraj = new System.Windows.Forms.Button();
            this.btnKopiraj = new System.Windows.Forms.Button();
            this.btnObrisiTekstIzPoljaZaUnos = new System.Windows.Forms.Button();
            this.btnSerijalizacija = new System.Windows.Forms.Button();
            this.btnBrisiListu = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lstListaRacunara
            // 
            this.lstListaRacunara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstListaRacunara.FormattingEnabled = true;
            this.lstListaRacunara.Location = new System.Drawing.Point(468, 7);
            this.lstListaRacunara.Name = "lstListaRacunara";
            this.lstListaRacunara.Size = new System.Drawing.Size(404, 433);
            this.lstListaRacunara.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proizvodjac: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Procesor: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ram memorija: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maticna ploca: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Napajanje: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Disk: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Memorija na disku: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cena: ";
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(146, 6);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.txtProizvodjac.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(146, 32);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 11;
            // 
            // txtProcesor
            // 
            this.txtProcesor.Location = new System.Drawing.Point(146, 58);
            this.txtProcesor.Name = "txtProcesor";
            this.txtProcesor.Size = new System.Drawing.Size(100, 20);
            this.txtProcesor.TabIndex = 12;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(146, 84);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(100, 20);
            this.txtRam.TabIndex = 13;
            // 
            // txtMaticnaPloca
            // 
            this.txtMaticnaPloca.Location = new System.Drawing.Point(146, 110);
            this.txtMaticnaPloca.Name = "txtMaticnaPloca";
            this.txtMaticnaPloca.Size = new System.Drawing.Size(100, 20);
            this.txtMaticnaPloca.TabIndex = 14;
            // 
            // txtNapajanje
            // 
            this.txtNapajanje.Location = new System.Drawing.Point(146, 136);
            this.txtNapajanje.Name = "txtNapajanje";
            this.txtNapajanje.Size = new System.Drawing.Size(100, 20);
            this.txtNapajanje.TabIndex = 15;
            // 
            // txtTipDiska
            // 
            this.txtTipDiska.Location = new System.Drawing.Point(146, 162);
            this.txtTipDiska.Name = "txtTipDiska";
            this.txtTipDiska.Size = new System.Drawing.Size(100, 20);
            this.txtTipDiska.TabIndex = 16;
            // 
            // txtMemorijaDiska
            // 
            this.txtMemorijaDiska.Location = new System.Drawing.Point(146, 188);
            this.txtMemorijaDiska.Name = "txtMemorijaDiska";
            this.txtMemorijaDiska.Size = new System.Drawing.Size(100, 20);
            this.txtMemorijaDiska.TabIndex = 17;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(146, 214);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 18;
            // 
            // btnDodajUListu
            // 
            this.btnDodajUListu.Location = new System.Drawing.Point(306, 7);
            this.btnDodajUListu.Name = "btnDodajUListu";
            this.btnDodajUListu.Size = new System.Drawing.Size(118, 56);
            this.btnDodajUListu.TabIndex = 19;
            this.btnDodajUListu.Text = "Dodaj u listu";
            this.btnDodajUListu.UseVisualStyleBackColor = true;
            this.btnDodajUListu.Click += new System.EventHandler(this.btnDodajUListu_Click);
            // 
            // btnUpali
            // 
            this.btnUpali.Location = new System.Drawing.Point(11, 272);
            this.btnUpali.Name = "btnUpali";
            this.btnUpali.Size = new System.Drawing.Size(99, 48);
            this.btnUpali.TabIndex = 20;
            this.btnUpali.Text = "Upali";
            this.btnUpali.UseVisualStyleBackColor = true;
            this.btnUpali.Click += new System.EventHandler(this.btnUpali_Click);
            // 
            // btnDostavi
            // 
            this.btnDostavi.Location = new System.Drawing.Point(11, 326);
            this.btnDostavi.Name = "btnDostavi";
            this.btnDostavi.Size = new System.Drawing.Size(99, 48);
            this.btnDostavi.TabIndex = 21;
            this.btnDostavi.Text = "Dostavi";
            this.btnDostavi.UseVisualStyleBackColor = true;
            this.btnDostavi.Click += new System.EventHandler(this.btnDostavi_Click);
            // 
            // btnUgasi
            // 
            this.btnUgasi.Location = new System.Drawing.Point(132, 272);
            this.btnUgasi.Name = "btnUgasi";
            this.btnUgasi.Size = new System.Drawing.Size(97, 48);
            this.btnUgasi.TabIndex = 22;
            this.btnUgasi.Text = "Ugasi";
            this.btnUgasi.UseVisualStyleBackColor = true;
            this.btnUgasi.Click += new System.EventHandler(this.btnUgasi_Click);
            // 
            // btnUnosTeksta
            // 
            this.btnUnosTeksta.Location = new System.Drawing.Point(132, 326);
            this.btnUnosTeksta.Name = "btnUnosTeksta";
            this.btnUnosTeksta.Size = new System.Drawing.Size(97, 48);
            this.btnUnosTeksta.TabIndex = 23;
            this.btnUnosTeksta.Text = "Unos teksta";
            this.btnUnosTeksta.UseVisualStyleBackColor = true;
            this.btnUnosTeksta.Click += new System.EventHandler(this.btnUnosTeksta_Click);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(246, 272);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(100, 48);
            this.btnKupi.TabIndex = 24;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // btnProgrmiraj
            // 
            this.btnProgrmiraj.Location = new System.Drawing.Point(246, 326);
            this.btnProgrmiraj.Name = "btnProgrmiraj";
            this.btnProgrmiraj.Size = new System.Drawing.Size(100, 48);
            this.btnProgrmiraj.TabIndex = 25;
            this.btnProgrmiraj.Text = "Programiraj";
            this.btnProgrmiraj.UseVisualStyleBackColor = true;
            this.btnProgrmiraj.Click += new System.EventHandler(this.btnProgrmiraj_Click);
            // 
            // btnKopiraj
            // 
            this.btnKopiraj.Location = new System.Drawing.Point(132, 380);
            this.btnKopiraj.Name = "btnKopiraj";
            this.btnKopiraj.Size = new System.Drawing.Size(97, 48);
            this.btnKopiraj.TabIndex = 26;
            this.btnKopiraj.Text = "Kopiraj na disk";
            this.btnKopiraj.UseVisualStyleBackColor = true;
            this.btnKopiraj.Click += new System.EventHandler(this.btnKopiraj_Click);
            // 
            // btnObrisiTekstIzPoljaZaUnos
            // 
            this.btnObrisiTekstIzPoljaZaUnos.Location = new System.Drawing.Point(306, 69);
            this.btnObrisiTekstIzPoljaZaUnos.Name = "btnObrisiTekstIzPoljaZaUnos";
            this.btnObrisiTekstIzPoljaZaUnos.Size = new System.Drawing.Size(118, 53);
            this.btnObrisiTekstIzPoljaZaUnos.TabIndex = 27;
            this.btnObrisiTekstIzPoljaZaUnos.Text = "Osvezi polja za unos";
            this.btnObrisiTekstIzPoljaZaUnos.UseVisualStyleBackColor = true;
            this.btnObrisiTekstIzPoljaZaUnos.Click += new System.EventHandler(this.btnObrisiTekstIzPoljaZaUnos_Click);
            // 
            // btnSerijalizacija
            // 
            this.btnSerijalizacija.Location = new System.Drawing.Point(306, 128);
            this.btnSerijalizacija.Name = "btnSerijalizacija";
            this.btnSerijalizacija.Size = new System.Drawing.Size(118, 54);
            this.btnSerijalizacija.TabIndex = 28;
            this.btnSerijalizacija.Text = "Serijalizacija";
            this.btnSerijalizacija.UseVisualStyleBackColor = true;
            this.btnSerijalizacija.Click += new System.EventHandler(this.btnSerijalizacija_Click);
            // 
            // btnBrisiListu
            // 
            this.btnBrisiListu.Location = new System.Drawing.Point(306, 188);
            this.btnBrisiListu.Name = "btnBrisiListu";
            this.btnBrisiListu.Size = new System.Drawing.Size(118, 46);
            this.btnBrisiListu.TabIndex = 29;
            this.btnBrisiListu.Text = "Obrisi desktop racunare";
            this.btnBrisiListu.UseVisualStyleBackColor = true;
            this.btnBrisiListu.Click += new System.EventHandler(this.btnBrisiListu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnBrisiListu);
            this.Controls.Add(this.btnSerijalizacija);
            this.Controls.Add(this.btnObrisiTekstIzPoljaZaUnos);
            this.Controls.Add(this.btnKopiraj);
            this.Controls.Add(this.btnProgrmiraj);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.btnUnosTeksta);
            this.Controls.Add(this.btnUgasi);
            this.Controls.Add(this.btnDostavi);
            this.Controls.Add(this.btnUpali);
            this.Controls.Add(this.btnDodajUListu);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtMemorijaDiska);
            this.Controls.Add(this.txtTipDiska);
            this.Controls.Add(this.txtNapajanje);
            this.Controls.Add(this.txtMaticnaPloca);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtProcesor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstListaRacunara);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListaRacunara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtProcesor;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtMaticnaPloca;
        private System.Windows.Forms.TextBox txtNapajanje;
        private System.Windows.Forms.TextBox txtTipDiska;
        private System.Windows.Forms.TextBox txtMemorijaDiska;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button btnDodajUListu;
        private System.Windows.Forms.Button btnUpali;
        private System.Windows.Forms.Button btnDostavi;
        private System.Windows.Forms.Button btnUgasi;
        private System.Windows.Forms.Button btnUnosTeksta;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Button btnProgrmiraj;
        private System.Windows.Forms.Button btnKopiraj;
        private System.Windows.Forms.Button btnObrisiTekstIzPoljaZaUnos;
        private System.Windows.Forms.Button btnSerijalizacija;
        private System.Windows.Forms.Button btnBrisiListu;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}

