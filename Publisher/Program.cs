using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using xmlExplain;

namespace Publisher
{
    internal class Program
    {
        public static string CalcMd5(string path)
        {
            byte[] hash;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    hash = md5.ComputeHash(stream);
                }
            }

            string md5String = BitConverter.ToString(hash).Replace("-", "");
            return md5String.ToLower();
        }

        static void Main(string[] args)
        {
            string version = args[0];

            string current = Directory.GetCurrentDirectory();
            string rzm = Path.Combine(current, "rzm.xml");
            if (File.Exists(rzm))
                File.Delete(rzm);

            string update = Path.Combine(current, "BenchLauncher.exe");
            string updateMd5 = CalcMd5(update);
            string[] files = Directory.GetFiles(current);
            Dictionary<string, string> md5s = new Dictionary<string, string>();
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                if ("BenchLauncher.exe" == name || "Publisher.exe" == name)
                    continue;

                string md5 = CalcMd5(file);
                md5s[name] = md5;
            }

            Node root = new Node("auto");
            root.AddAttribute("md5", updateMd5);
            root.AddAttribute("version", version);

            Node rcs = root.AddChild("rcs");
            foreach (var md5 in md5s)
            {
                Node rc = rcs.AddChild("rc");
                rc.AddAttribute("name", md5.Key);
                rc.AddAttribute("md5", md5.Value);
            }


            XmlWriter writer = new XmlWriter(rzm);
            writer.Write(root);
        }
    }
}