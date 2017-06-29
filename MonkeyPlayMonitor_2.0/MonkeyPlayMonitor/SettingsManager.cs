using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayBoxMonitor
{
    internal class SettingsManager
    {
        private BinaryFormatter bFormatter;
        private FileStream fStream;
        private static string appDataDirectory = Directory.GetCurrentDirectory()+@"\App Data", extensionsDirectory = "Extensions";
        private string fileName, settingsDirectory = appDataDirectory+@"\Configurtion", setupDirectory = appDataDirectory+@"\Setup Files";

        public static string ExtensionsDirectory { get { return extensionsDirectory; } }

        public SettingsManager(bool setup = false)
        {
            bFormatter=new BinaryFormatter();
            VerifyDirectories();
            if(!setup)
                fileName=settingsDirectory+@"\settings.dat";
            else
                fileName=setupDirectory+@"\setup.dat";
        }

        private void VerifyDirectories()
        {
            if(!Directory.Exists(appDataDirectory))
                Directory.CreateDirectory(appDataDirectory);
            if(!Directory.Exists(settingsDirectory))
                Directory.CreateDirectory(settingsDirectory);
            if(!Directory.Exists(setupDirectory))
                Directory.CreateDirectory(setupDirectory);
            if(!Directory.Exists(extensionsDirectory))
                Directory.CreateDirectory(extensionsDirectory);
        }

        public Settings LoadSettings()
        {
            using(fStream=new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
            {
                Stream stream = fStream;
                FileInfo settingsFile = new FileInfo(fileName);
                if(settingsFile.Length>0)
                    return (Settings)bFormatter.Deserialize(stream);
            }
            return null;
        }

        public Setup LoadSetup()
        {
            try
            {
                using(fStream=new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
                {
                    Stream stream = fStream;
                    FileInfo settingsFile = new FileInfo(fileName);
                    if(settingsFile.Length>0)
                        return (Setup)bFormatter.Deserialize(stream);
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("PBM - SM ::::> Error failed to load setup: "+e.Message+e.Source);
            }
            return null;
        }

        public void SaveSettings(Settings editedSettings)
        {
            File.Delete(fileName);
            using(fStream=new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
            {
                fStream.Seek(0,SeekOrigin.Begin);
                using(Stream stream = fStream)
                {
                    bFormatter.Serialize(stream,editedSettings);
                }
            }
        }

        public void SaveSetup(Setup editedSetup)
        {
            File.Delete(fileName);
            using(fStream=new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
            {
                fStream.Seek(0,SeekOrigin.Begin);
                using(Stream stream = fStream)
                {
                    bFormatter.Serialize(stream,editedSetup);
                    stream.Flush();
                }
            }
        }

        public void ResetSettings()
        {
            Settings originalSettings = new Settings();
            File.Delete(fileName);
            SaveSettings(originalSettings);
            VerifyDirectories();
        }

        public void ResetSetUp()
        {
            Setup originalSetup = new Setup();
            File.Delete(fileName);
            SaveSetup(originalSetup);
            VerifyDirectories();
        }
    }
}