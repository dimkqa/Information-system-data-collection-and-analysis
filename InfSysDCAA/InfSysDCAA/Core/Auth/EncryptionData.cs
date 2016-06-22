using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace InfSysDCAA.Core.Auth
{
    /// <summary>
    /// Шифрование авторизационных данных
    /// </summary>
    public static class EncryptionData
    {
        /// <summary>
        /// Добавочная часть для шифрования (соль)
        /// </summary>
        private static string Salt = "O3D4fgps3adasd3";

        /// <summary>
        /// Алгоритм хэширования
        /// </summary>
        private static string AlgoritmHash = "SHA1";

        /// <summary>
        /// Число итераций прогона
        /// </summary>
        private static int PasswordIteration = 2;

        /// <summary>
        /// Вектор инициализации
        /// </summary>
        private static string InitVector = "OFRna73m*aze01xY";

        /// <summary>
        /// Размер ключа
        /// </summary>
        private static int SizeKey = 256;


        /// <summary>
        /// Шифрование логина
        /// </summary>
        /// <param name="text">Текст для шифрования</param>
        /// <param name="password">Пароль</param>
        /// <returns>Хэш-строка с результатом</returns>
        public static string EncryptLogin(string text, string password)
        {
            return Encrypt(text, password);
        }

        /// <summary>
        /// Шифрование пароля
        /// </summary>
        /// <param name="text">Текст для шифрования</param>
        /// <param name="password">Пароль</param>
        /// <returns>Хэш-строка с результатом</returns>
        public static string EncryptPassword(string text, string password)
        {
            return Encrypt(password, text);
        }

        /// <summary>
        /// Шифрование
        /// </summary>
        /// <param name="plainText">Текст для шифрования</param>
        /// <param name="password">Пароль для шифрования</param>
        /// <returns></returns>
        private static string Encrypt(string plainText, string password)
        {
            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(InitVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(Salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, AlgoritmHash, PasswordIteration);
            byte[] keyBytes = derivedPassword.GetBytes(SizeKey / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <param name="cipherText">Зашифрованный текст</param>
        /// <param name="password">Пароль для расшифровки</param>
        /// <returns></returns>
        private static string Decrypt(string cipherText, string password)
        {
            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(InitVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(Salt);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, AlgoritmHash, PasswordIteration);
            byte[] keyBytes = derivedPassword.GetBytes(SizeKey / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount = 0;

            using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream(cipherTextBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }
    }
}
