using Sustav_za_kriptiranje_i_dekriptiranje.Kriptiranje;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sustav_za_kriptiranje_i_dekriptiranje
{
    class FIleManagement
    {
        private static string radniDirektorij { get; set; }
        private static string secretKeyPath { get; set; }
        private static string privateKeyPath { get; set; }
        private static string publicKeyPath { get; set; }
        public static void OdabirRadnogDirektorija()
        {
            FolderBrowserDialog direktorij = new FolderBrowserDialog();
            if (direktorij.ShowDialog() == DialogResult.OK)
            {
                radniDirektorij = direktorij.SelectedPath;
                privateKeyPath = radniDirektorij + @"/Privatni_kljuc.txt";
                secretKeyPath = radniDirektorij + @"/Tajni_kljuc.txt";                
                publicKeyPath = radniDirektorij + @"/Javni_kljuc.txt";
            }
            else if (direktorij.SelectedPath.Length <= 0 || radniDirektorij.Length <= 0)
            {
                throw new Exception("Niste odabrali radni direktorij!");
            }
        }        
        public static bool ProvjeraPostojanostiDatoteka()
        {
            bool privateKey = File.Exists(privateKeyPath);
            bool secretKey = File.Exists(secretKeyPath);
            bool publicKey = File.Exists(publicKeyPath);
            if (privateKey&&secretKey&&publicKey)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void KreirajDatoteke()
        {
            if (!ProvjeraPostojanostiDatoteka())
            {                
                File.Create(privateKeyPath).Close();              
                File.Create(secretKeyPath).Close();
                File.Create(publicKeyPath).Close();                
                string secretKey, privateKey, publicKey;
                string[] generiraniKljucevi = new string[2];
                generiraniKljucevi = RSA.GeneriranjeKljuceva();
                secretKey = AES.GenerirajSecretKey();
                privateKey = generiraniKljucevi[0];
                publicKey = generiraniKljucevi[1];
                UnesiUDatoteku(secretKeyPath, secretKey);
                UnesiUDatoteku(privateKeyPath, privateKey);
                UnesiUDatoteku(publicKeyPath, publicKey);
            }
        }
        public static string VratiRadniDirektorij()
        {
            return radniDirektorij;
        }
        public static void UnesiUDatoteku(string putanja, string tekst)
        {
            File.WriteAllText(putanja, tekst);
        }
        public static string UcitajSadrzajDatoteke(string putanja)
        {
            if (File.Exists(putanja))
            {
                return File.ReadAllText(putanja);
            }
            else
            {
                throw new Exception("Datoteka ne postoji! Na lokaciji: " + putanja);
            }
        }
       
        public static string UcitajSadrzajZaKriptiranje()
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string putanja = fd.FileName;
                return putanja;
            }
            throw new Exception("Neispravna datoteka!");
        }
        public static string KreirajAesKripitranuDatoteku()
        {
            string putanja = radniDirektorij + @"/Kriptirani_sadrzaj_AES.txt";
            if (!File.Exists(putanja))
            {
                File.Create(putanja).Close();
            }
            return putanja;
        }
        public static string KreirajAesDekriptiranuDatoteku()
        {
            string putanja = radniDirektorij + @"/Dekriptirani_sadrzaj_AES.txt";
            if (!File.Exists(putanja))
            {
                File.Create(putanja).Close();
            }
            return putanja;
        }
        public static void IzbrisiDatoteke()
        {
            string secretKey = radniDirektorij + @"/Tajni_kljuc.txt";
            string privateKey = radniDirektorij + @"/Privatni_kljuc.txt";
            string publicKey = radniDirektorij + @"/Javni_kljuc.txt";
            string kriptiraniSadrzajRsa = radniDirektorij + @"/Kriptirani_sadrzaj_RSA.txt";
            string dekriptiraniSadrzajRsa = radniDirektorij + @"/Dekriptirani_sadrzaj_RSA.txt";
            string kriptiraniSadrzajAes = radniDirektorij + @"/Kriptirani_sadrzaj_AES.txt";
            string dekriptiraniSadrzajAes = radniDirektorij + @"/Dekriptirani_sadrzaj_AES.txt";
            string sazetak = radniDirektorij + @"/Sazetak.txt";
            string digPotpis = radniDirektorij + @"/Digitalni_potpis.txt";
            if (File.Exists(privateKey))
            {
                File.Delete(privateKey);
            }
            if (File.Exists(secretKey))
            {
                File.Delete(secretKey);
            } 
            if (File.Exists(publicKey))
            {
                File.Delete(publicKey);
            }
            if (File.Exists(kriptiraniSadrzajRsa))
            {
                File.Delete(kriptiraniSadrzajRsa);
            }
            if (File.Exists(dekriptiraniSadrzajRsa))
            {
                File.Delete(dekriptiraniSadrzajRsa);
            }
            if (File.Exists(kriptiraniSadrzajAes))
            {
                File.Delete(kriptiraniSadrzajAes);
            }
            if (File.Exists(dekriptiraniSadrzajAes))
            {
                File.Delete(dekriptiraniSadrzajAes);
            }
            if (File.Exists(sazetak))
            {
                File.Delete(sazetak);
            }
            if (File.Exists(digPotpis))
            {
                File.Delete(digPotpis);
            }
        }
        public static string KreirajRsaDatotekuKriptiranogSadrzaja()
        {
            string putanja = radniDirektorij + @"/Kriptirani_sadrzaj_RSA.txt";
            if (!File.Exists(putanja))
            {
                File.Create(putanja).Close();
            }
            return putanja;
        }
        public static string KreirajRsaDatotekuDekriptiranogSadrzaja()
        {
            string putanja = radniDirektorij + @"\Dekriptirani_sadrzaj_RSA.txt";
            if (!File.Exists(putanja))
            {
                File.Create(putanja).Close();
            }
            return putanja;
        }
        public static byte[] UcitajTrazenuDatoteku(string putanja)
        {
            byte[] sadrzaj;
            if (File.Exists(putanja) && (Path.GetExtension(putanja) == ".txt"))
            {
                sadrzaj = Encoding.UTF8.GetBytes(File.ReadAllText(putanja));
            }
            else
            {
                throw new Exception("Dokument ne postoji ili nije .txt formata!");
            }
            return sadrzaj;
        }
        public static string UcitajDatotekuDigitalnogPotpisa()
        {
            string radniDirektorij = VratiRadniDirektorij();
            OpenFileDialog datoteka = new OpenFileDialog();
            if (datoteka.ShowDialog() == DialogResult.OK)
            {
                if (datoteka.FileName.Length <= 0)
                {
                    throw new Exception("Niste odabrali datoteku za digitalni potpis!");
                }
                else
                {
                    return datoteka.FileName;
                }
            }
            else
            {
                throw new Exception("Niste odbrali datoteku za digitalni potpis!");
            }
        }
        public static string KreirajDatotekuSazetka()
        {
            string putanjaDatoteke = "";
            string radniDirektorij = VratiRadniDirektorij();
            putanjaDatoteke = radniDirektorij + @"/Sazetak.txt";
            if (File.Exists(putanjaDatoteke))
            {
                File.Delete(putanjaDatoteke);
                File.Create(putanjaDatoteke).Close();
            }
            else
            {
                File.Create(putanjaDatoteke).Close();
            }
            return putanjaDatoteke;
        }

        public static string KreirajDatotekuDigitalnogPotpisa()
        {
            string putanjaDatoteke = "";
            putanjaDatoteke = VratiRadniDirektorij() + @"/Digitalni_potpis.txt";
            if (File.Exists(putanjaDatoteke))
            {
                File.Delete(putanjaDatoteke);
                File.Create(putanjaDatoteke).Close();
            }
            else
            {
                File.Create(putanjaDatoteke).Close();
            }
            return putanjaDatoteke;
        }
    }
}
