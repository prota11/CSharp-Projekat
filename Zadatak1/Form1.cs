using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;


namespace Zadatak1
{
    public partial class Form1 : Form
    {
        List<DesktopRacunar> ListaDesktopRacunara = new List<DesktopRacunar>();
        public Form1()
        {
            InitializeComponent();
        }

        // dodavanje racunara u genericku listu i ispis u listbox kontroli
        private void btnDodajUListu_Click(object sender, EventArgs e)
        {
            try
            {
                DesktopRacunar desktopRacunar = new DesktopRacunar() { proizvodjac = txtProizvodjac.Text, model = txtModel.Text, procesor = txtProcesor.Text, ram = Convert.ToInt32(txtRam.Text), maticnaPloca = txtMaticnaPloca.Text, napajanje = txtNapajanje.Text, tipDiska = txtTipDiska.Text, memorijaDiska = Convert.ToInt32(txtMemorijaDiska.Text), cena = Convert.ToDouble(txtCena.Text) };

                ListaDesktopRacunara.Add(desktopRacunar);

                PrikaziListu();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpali_Click(object sender, EventArgs e)
        {
            DesktopRacunar racunar = new DesktopRacunar();
            MessageBox.Show(racunar.Upali());
        }

        private void btnUgasi_Click(object sender, EventArgs e)
        {
            DesktopRacunar racunar = new DesktopRacunar();
            MessageBox.Show(racunar.Ugasi());
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            DesktopRacunar racunar = new DesktopRacunar();
            MessageBox.Show(racunar.Kupi());
        }

        private void btnDostavi_Click(object sender, EventArgs e)
        {
            DesktopRacunar racunar = new DesktopRacunar();
            MessageBox.Show(racunar.Dostavi());
        }

        private void btnUnosTeksta_Click(object sender, EventArgs e)
        {
            DesktopRacunar racunar = new DesktopRacunar();
            MessageBox.Show(racunar.UnosTeksta());
        }

        private void btnProgrmiraj_Click(object sender, EventArgs e)
        {
            DesktopRacunar racunar = new DesktopRacunar();
            MessageBox.Show(racunar.Programiraj());
        }

        private void btnKopiraj_Click(object sender, EventArgs e)
        {
            DesktopRacunar racunar = new DesktopRacunar();
            MessageBox.Show(racunar.KopirajNaDisk());
        }

        // uklanjanje teksta iz svih textbox kontrola
        private void btnObrisiTekstIzPoljaZaUnos_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control textbox in this.Controls)
                {
                    if (textbox is TextBox)
                    {
                        textbox.Text = string.Empty;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // serijalizacija u JSON format i cuvanje u fajlu DesktopRacunari.json
        private void btnSerijalizacija_Click(object sender, EventArgs e)
        {
            try
            {
                string imeFajla = "";

                dlgSaveFile.Title = "Save file";
                dlgSaveFile.DefaultExt = "json";
                dlgSaveFile.Filter = "JSON fajlovi|*.json";

                // korisnik odustao od Save dijaloga
                if (dlgSaveFile.ShowDialog() == DialogResult.Cancel) {return;}

                imeFajla = dlgSaveFile.FileName;

                // 1. nacin
                //JavaScriptSerializer serializer = new JavaScriptSerializer();
                //string str = serializer.Serialize(ListaDesktopRacunara);

                // 2. nacin - formatiran
                string str = JsonConvert.SerializeObject(ListaDesktopRacunara, Formatting.Indented);

                // upisivanje u fajl
                StreamWriter sw = new StreamWriter(imeFajla);
                sw.Write(str);
                sw.Flush();
                sw.Close();
                MessageBox.Show("Uspesno snimljeno u fajl DesktopRacunari.json");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // brisanje svih podataka iz genericke liste
        private void btnBrisiListu_Click(object sender, EventArgs e)
        {
            try
            {
                ListaDesktopRacunara.Clear();
                PrikaziListu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // zatvaranje aplikacije na dugme ESC
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        // prikaz svih clanova genericke liste
        private void PrikaziListu()
        {
            try
            {
                lstListaRacunara.Items.Clear();
                foreach (DesktopRacunar racunar in ListaDesktopRacunara)
                {
                    lstListaRacunara.Items.Add(ListaDesktopRacunara.IndexOf(racunar) + 1 + ".");
                    lstListaRacunara.Items.Add("Proizvodjac: " + racunar.proizvodjac);
                    lstListaRacunara.Items.Add("Model: " + racunar.model);
                    lstListaRacunara.Items.Add("Procesor: " + racunar.procesor);
                    lstListaRacunara.Items.Add("Ram memorija: " + racunar.ram + "GB");
                    lstListaRacunara.Items.Add("Maticna ploca: " + racunar.maticnaPloca);
                    lstListaRacunara.Items.Add("Napajanje: " + racunar.napajanje);
                    lstListaRacunara.Items.Add("Disk: " + racunar.tipDiska);
                    lstListaRacunara.Items.Add("Memorija diska: " + racunar.memorijaDiska + "GB");
                    lstListaRacunara.Items.Add("Cena: " + racunar.cena + " RSD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
