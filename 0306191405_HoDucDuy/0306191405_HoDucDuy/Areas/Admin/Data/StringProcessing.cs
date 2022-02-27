using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Data
{
    public class StringProcessing
    {
        public static string Base64Encode(string plainText)
        {
            try
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            catch
            {
                return null;
            }
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string MD5Encode(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                try
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
                catch
                {
                    return null;
                }
            }
        }

        //public static string Encrypt(string text)
        //{
        //    using (var md5 = new MD5CryptoServiceProvider())
        //    {
        //        using (var tdes = new TripleDESCryptoServiceProvider())
        //        {
        //            tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(text));
        //            tdes.Mode = CipherMode.ECB;
        //            tdes.Padding = PaddingMode.PKCS7;

        //            using (var transform = tdes.CreateEncryptor())
        //            {
        //                byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
        //                byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
        //                return Convert.ToBase64String(bytes, 0, bytes.Length);
        //            }
        //        }
        //    }
        //}

        //public static string Decrypt(string cipher)
        //{
        //    using (var md5 = new MD5CryptoServiceProvider())
        //    {
        //        using (var tdes = new TripleDESCryptoServiceProvider())
        //        {
        //            tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(cipher));
        //            tdes.Mode = CipherMode.ECB;
        //            tdes.Padding = PaddingMode.PKCS7;

        //            using (var transform = tdes.CreateDecryptor())
        //            {
        //                byte[] cipherBytes = Convert.FromBase64String(cipher);
        //                byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
        //                return UTF8Encoding.UTF8.GetString(bytes);
        //            }
        //        }
        //    }
        //}

    }
}
