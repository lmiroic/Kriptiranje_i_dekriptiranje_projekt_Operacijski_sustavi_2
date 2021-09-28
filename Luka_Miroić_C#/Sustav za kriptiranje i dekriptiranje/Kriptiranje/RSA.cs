using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sustav_za_kriptiranje_i_dekriptiranje.Kriptiranje
{
    public class RSA
    {
        private static RSACryptoServiceProvider rsa;
        private static RSAParameters rsaKeyInfo;
        private static string publicKey { get; set; }
        private static string privateKey { get; set; }
        public static string[] GeneriranjeKljuceva()
        {          
            rsa = new RSACryptoServiceProvider(2048);
            rsaKeyInfo = rsa.ExportParameters(true);
            publicKey = Convert.ToBase64String(rsaKeyInfo.Modulus);
            privateKey = Convert.ToBase64String(rsaKeyInfo.D);
            string[] listaKljucevaRSA = new string[2];
            listaKljucevaRSA[0] = privateKey;
            listaKljucevaRSA[1] = publicKey;
            return listaKljucevaRSA;
        }
        public static string VratiPublicKey()
        {
            return publicKey;
        }
        public static string VratiPrivateKey()
        {
            return privateKey;
        }
        
        public static string Kriptiranje(byte[] tekstZaKriptiranje)
        {
            byte[] kriptiraniTekst = rsa.Encrypt(tekstZaKriptiranje, false);
            return Convert.ToBase64String(kriptiraniTekst);
        }
        public static string Dekriptiranje(byte[] kriptiraniTekst)
        {
            byte[] dekriptiranTekst = rsa.Decrypt(kriptiraniTekst, false);
            return Encoding.UTF8.GetString(dekriptiranTekst);
        }
        public static byte[] RacunanjeSazetkaDatoteke(byte[] sadrzajDatoteke)
        {
            SHA512Managed sha512 = new SHA512Managed();
            return sha512.ComputeHash(sadrzajDatoteke, 0, sadrzajDatoteke.Length);
        }
        public static byte[] DigitalnoPotpisivanje(byte[] sadrzajDatoteke)
        {
            byte[] sazetakDatoteke = RacunanjeSazetkaDatoteke(sadrzajDatoteke);
            return rsa.SignHash(sazetakDatoteke, CryptoConfig.MapNameToOID("SHA512"));
        }
        public static bool ProvjeraDigitalnogPotpisa(byte[] datoteka, byte[] digitalniPotpis)
        {
            byte[] sazetakDatoteke = RacunanjeSazetkaDatoteke(datoteka);
            return rsa.VerifyHash(sazetakDatoteke, CryptoConfig.MapNameToOID("SHA512"), digitalniPotpis);
        }
    }
}
