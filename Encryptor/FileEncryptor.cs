using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public static class FileEncryptor
    {
        private static string XORCipher(string inputContent, string key, BackgroundWorker backgroundWorker)
        {
            if (inputContent == null || key == null)
                throw new ArgumentNullException("Wrong argument passed to file encryptor");

            int dataLen = inputContent.Length;
            int keyLen = key.Length;

            char[] output = new char[dataLen];

            for (int i = 0; i < dataLen; ++i)
            {
                output[i] = (char)(inputContent[i] ^ key[i % keyLen]);

                int progressPercent = (int)(((i + 1.0) / inputContent.Length) * 100);
                backgroundWorker.ReportProgress(progressPercent);
            }

            return new string(output);
        }

        public static string Encrypt(string inputContent, string key, BackgroundWorker backgroundWorker) =>
            XORCipher(inputContent, key, backgroundWorker);

        public static string Decrypt(string inputContent, string key, BackgroundWorker backgroundWorker) =>
            XORCipher(inputContent, key, backgroundWorker);
    }
}
