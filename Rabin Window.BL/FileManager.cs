using System.IO;
using System.Text;
using RabinLib;
using System.Numerics;
using System.Linq;
namespace Rabin_Window.BL
{
    public class FileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public bool isExist(string filepath)
        {
            return File.Exists(filepath);
        }

        public string GetContent(string path, BigInteger SecretKeyOne, BigInteger SecretKeyTwo)
        {
            return GetContent(path, _defaultEncoding, SecretKeyOne, SecretKeyTwo);
        }

        public string GetContent(string path, Encoding encoding, BigInteger SecretKeyOne, BigInteger SecretKeyTwo)
        {
            BigInteger[] conten = File.ReadAllLines(path, encoding).Select(p => BigInteger.Parse(p)).ToArray();

            string result = Rabin.DecryptionBigText(conten, SecretKeyOne, SecretKeyTwo);

            return result;
        }

        public void SaveContent(string content, string filepath, BigInteger OpenKey)
        {
            SaveContent(content, filepath, _defaultEncoding, OpenKey);
        }

        public void SaveContent(string content, string filepath, Encoding encoding, BigInteger OpenKey)
        {
            BigInteger[] EncrypArr = Rabin.EncryptionBigText(content, OpenKey);

            string output = "";

            for (int i = 0; i < EncrypArr.Length; i++)
                output += EncrypArr[i] + "\n";

            File.WriteAllText(filepath, output, encoding);

        }

        public int GetSymbloCount(string content)
        {
            return content.Length;
        }

    }
}
