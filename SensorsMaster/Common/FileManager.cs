using SensorsMaster.Common.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Common
{
    public static class FileManager
    {
        public static string ProjectPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
        public static string ResourcePath = Path.Combine(ProjectPath, "SensorsMaster", "Resources");
        public static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string ConfigFile = Path.Combine(ResourcePath, "config.json");

        public static string GetSavePathFromDialog(Extension extension)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.InitialDirectory = DesktopPath;

            if(extension != null)
            {
                dialog.DefaultExt = extension.Value; // Default file extension
                dialog.Filter = extension.Filter;
            }

            if (dialog.ShowDialog() == true)
                return dialog.FileName;
            else
                return null;
        }
        public static string GetSavePathFromDialog()
        {
            return GetSavePathFromDialog(null);
        }
        public static string GetLoadPathFromDialog(Extension extension)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.InitialDirectory = DesktopPath;
            
            if(extension != null)
            {
                dialog.DefaultExt = extension.Value;
                dialog.Filter = extension.Filter;
            }

            if (dialog.ShowDialog() == true)
                return dialog.FileName;
            else
                return null;
        }

        public static void Save(string text, string path)
        {
            throw new NotImplementedException();
        }

        public static Stream ReadStream(string path)
        {
            Stream stream = new MemoryStream();
            using (var fs = new FileStream(path, FileMode.Open))
            {
                fs.Seek(0, SeekOrigin.Begin);
                fs.CopyTo(stream);
            }
            return stream;
        }
        public static void SaveStream(Stream stream, string path)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(fs);
            }
        }
        public static void SaveConfig(Stream stream)
        {
            SaveStream(stream, ConfigFile);
        }
        public static Stream ReadConfig()
        {
            if (File.Exists(FileManager.ConfigFile))
                return ReadStream(ConfigFile);
            else
                return null;
        }

    }
}
