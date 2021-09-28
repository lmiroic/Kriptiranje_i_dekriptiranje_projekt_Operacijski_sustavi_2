using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sustav_za_kriptiranje_i_dekriptiranje.Kriptiranje
{
    public class AES
    {
        private static Aes aes;
        private static string secretKey;

        public static string GenerirajSecretKey()
        {
            aes = Aes.Create();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.GenerateKey();
            aes.GenerateIV();
            secretKey = Convert.ToBase64String(aes.Key);
            return secretKey;
        }
        public static string VratiSecretKey()
        {
            return secretKey;
        }

        public static byte[] Kriptiranje(string tekst)
        {
            byte[] kriptiraniTekst;
            ICryptoTransform encryptorTransform = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream memStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptorTransform, CryptoStreamMode.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(tekst);
                    }
                    kriptiraniTekst = memStream.ToArray();
                }
            }
            return kriptiraniTekst;
        }
        public static string Dekriptiranje(string kriptiraniTekst)
        {
            byte[] convertiraniKriptiraniTekst = Convert.FromBase64String(kriptiraniTekst);
            string dekriptiraniTekst = "";
            ICryptoTransform decryptorTransform = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream memStream = new MemoryStream(convertiraniKriptiraniTekst))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memStream, decryptorTransform, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader(cryptoStream))
                    {
                        dekriptiraniTekst = streamReader.ReadToEnd();
                    }
                }
            }
            return dekriptiraniTekst;
        }
    }
}
