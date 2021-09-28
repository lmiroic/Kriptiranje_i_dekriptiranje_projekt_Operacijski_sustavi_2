using Sustav_za_kriptiranje_i_dekriptiranje.Kriptiranje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sustav_za_kriptiranje_i_dekriptiranje
{
    public partial class FormKriptiranje : Form
    {
        public FormKriptiranje()
        {
            InitializeComponent();
            txtRadniDirektorij.Enabled = false;
            txtPrivateKey.Enabled = false;
            txtPublicKey.Enabled = false;
            txtSecretKey.Enabled = false;            
        }
        private void OsvjeziTxtBoxUlazniPodaci(string tekst)
        {
            txtUlazniPodaci.Text = tekst;
        }

        private void btnOdabirDirektorija_Click(object sender, EventArgs e)
        {
            try
            {
                FIleManagement.OdabirRadnogDirektorija();
                txtRadniDirektorij.Text = FIleManagement.VratiRadniDirektorij();
                if (FIleManagement.ProvjeraPostojanostiDatoteka())
                {
                    FIleManagement.IzbrisiDatoteke();
                }
                this.btnGeneriranjeKljuceva.Enabled = true;
                this.btnOdabirDirektorija.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGeneriranjeKljuceva_Click(object sender, EventArgs e)
        {
            FIleManagement.KreirajDatoteke();
            txtSecretKey.Text = AES.VratiSecretKey();
            txtPrivateKey.Text = RSA.VratiPrivateKey();
            txtPublicKey.Text = RSA.VratiPublicKey();
            this.btnIzracunavanjeSazetka.Enabled = true;
            this.btnDigitalnoPotpisivanje.Enabled = true;
            this.btnGeneriranjeKljuceva.Enabled = false;
            this.btnProvjeraPotpisa.Enabled = true;
            this.btnUlaznaDatoteka.Enabled = true;
        }

        private void btnUlaznaDatoteka_Click(object sender, EventArgs e)
        {
            string putanja = "";
            try
            {
                putanja = FIleManagement.UcitajSadrzajZaKriptiranje();
                if (putanja.Length > 0 && putanja != "")
                {
                    txtUlazniPodaci.Text = FIleManagement.UcitajSadrzajDatoteke(putanja);
                }
                this.btnAsimetricnoKriptiranje.Enabled = true;
                this.btnAsimetricnoDekriptiranje.Enabled = true;
                this.btnSimetricnoKriptiranje.Enabled = true;
                this.btnSimetricnoDekriptiranje.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnSimetricnoKriptiranje_Click(object sender, EventArgs e)
                {
                    string putanja = FIleManagement.KreirajAesKripitranuDatoteku();
                    byte[] kriptiranSadrzaj = AES.Kriptiranje(txtUlazniPodaci.Text);
                    string sadrzaj = Convert.ToBase64String(kriptiranSadrzaj);
                    FIleManagement.UnesiUDatoteku(putanja, sadrzaj);
                    OsvjeziTxtBoxUlazniPodaci(sadrzaj);
                }
        private void btnSimetricnoDekriptiranje_Click(object sender, EventArgs e)
        {
            string putanja = FIleManagement.KreirajAesDekriptiranuDatoteku();
            string putanjaKriptiraneDatoteke = FIleManagement.VratiRadniDirektorij() + @"/Kriptirani_sadrzaj_AES.txt";
            string kriptiraniSadrzaj = FIleManagement.UcitajSadrzajDatoteke(putanjaKriptiraneDatoteke);
            string dekriptiraniSadrzaj = AES.Dekriptiranje(kriptiraniSadrzaj);
            FIleManagement.UnesiUDatoteku(putanja, dekriptiraniSadrzaj);
            OsvjeziTxtBoxUlazniPodaci(dekriptiraniSadrzaj);
        }

        private void btnAsimetricnoKriptiranje_Click_1(object sender, EventArgs e)
        {
            string putanja = FIleManagement.KreirajRsaDatotekuKriptiranogSadrzaja();
            byte[] sadrzajKriptiranja = Encoding.UTF8.GetBytes(txtUlazniPodaci.Text);
            string kriptiraniSadrzaj = RSA.Kriptiranje(sadrzajKriptiranja);
            FIleManagement.UnesiUDatoteku(putanja, kriptiraniSadrzaj);
            OsvjeziTxtBoxUlazniPodaci(kriptiraniSadrzaj);
        }

        private void btnAsimetricnoDekriptiranje_Click_1(object sender, EventArgs e)
        {
            string putanjaDatot = FIleManagement.KreirajRsaDatotekuDekriptiranogSadrzaja();
            string putanja = FIleManagement.VratiRadniDirektorij() + @"/Kriptirani_sadrzaj_RSA.txt";
            string kriptiranSadrzaj = FIleManagement.UcitajSadrzajDatoteke(putanja);
            byte[] tekst = Convert.FromBase64String(kriptiranSadrzaj);
            string dekriptiraniSadrzaj = RSA.Dekriptiranje(tekst);
            FIleManagement.UnesiUDatoteku(putanjaDatot, dekriptiraniSadrzaj);
            OsvjeziTxtBoxUlazniPodaci(dekriptiraniSadrzaj);
        }

        private void btnIzracunavanjeSazetka_Click(object sender, EventArgs e)
        {
            string putanja = "";
            byte[] sadrzaj;           
            try
            {
                putanja = FIleManagement.UcitajDatotekuDigitalnogPotpisa();
                sadrzaj = FIleManagement.UcitajTrazenuDatoteku(putanja);
                byte[] sazetakDatoteke = RSA.RacunanjeSazetkaDatoteke(sadrzaj);
                string putanjaSazetka = FIleManagement.KreirajDatotekuSazetka();
                string izracunatSazetak = Convert.ToBase64String(sazetakDatoteke);
                FIleManagement.UnesiUDatoteku(putanjaSazetka, izracunatSazetak);
                txtUlazniPodaci.Text = izracunatSazetak;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDigitalnoPotpisivanje_Click_1(object sender, EventArgs e)
        {
            string putanjaDigitalnogPotpisa = FIleManagement.KreirajDatotekuDigitalnogPotpisa();
            string datotekaPotpisivanja = "";
            OpenFileDialog ucitanaDatoteka = new OpenFileDialog();
            if (ucitanaDatoteka.ShowDialog() == DialogResult.OK)
            {
                datotekaPotpisivanja = ucitanaDatoteka.FileName;
            }
            byte[] sadrzajUcitaneDatoteke = FIleManagement.UcitajTrazenuDatoteku(datotekaPotpisivanja);
            byte[] sadrzajDigitalnogPotpisa = RSA.DigitalnoPotpisivanje(sadrzajUcitaneDatoteke);
            string stringSadrzajDigitalnogPotpisa = Convert.ToBase64String(sadrzajDigitalnogPotpisa);
            FIleManagement.UnesiUDatoteku(putanjaDigitalnogPotpisa, stringSadrzajDigitalnogPotpisa);
            txtUlazniPodaci.Text = stringSadrzajDigitalnogPotpisa;
        }

        private void btnProvjeraPotpisa_Click(object sender, EventArgs e)
        {
            string putanja = "";
            OpenFileDialog odabranaDatoteka = new OpenFileDialog();
            if (odabranaDatoteka.ShowDialog() == DialogResult.OK)
            {
                putanja = odabranaDatoteka.FileName;
            }
            string radniDirektorij = FIleManagement.VratiRadniDirektorij();
            string sadrzajDigPotpisa = FIleManagement.UcitajSadrzajDatoteke(radniDirektorij + @"/Digitalni_potpis.txt");
            byte[] DigitalniPotpis = Convert.FromBase64String(sadrzajDigPotpisa);
            byte[] sadrzajDatoteke = FIleManagement.UcitajTrazenuDatoteku(putanja);
            bool ispravnostDigitalnogPotpisa = false;
            ispravnostDigitalnogPotpisa=RSA.ProvjeraDigitalnogPotpisa(sadrzajDatoteke, DigitalniPotpis);
            if (ispravnostDigitalnogPotpisa)
            {
                MessageBox.Show("Datoteka je valjana!");
            }
            else
            {
                MessageBox.Show("Datoteka nije valjana!");
            }
        }
    }
}
