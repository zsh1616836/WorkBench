﻿using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WorkBench
{
    public static class Tools
    {
        public static void OpenDoubleBuffer(this Control c)
        {
            Type type = c.GetType();
            PropertyInfo pi = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            if (pi != null)
                pi.SetValue(c, true, null);
        }

        public static bool DeleteDirectory(string targetDir)
        {
            if (!Directory.Exists(targetDir))
                return true;
            string[] files = Directory.GetFiles(targetDir);
            string[] dirs = Directory.GetDirectories(targetDir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                try
                {
                    File.Delete(file);
                }
                catch (Exception)
                {
                    return false;
                }
            }

            foreach (string dir in dirs)
            {
                if (!DeleteDirectory(dir))
                    return false;
            }

            Directory.Delete(targetDir, false);
            return true;
        }
    }
}
