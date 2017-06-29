using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayBox
{
    public class PropertiesManager
    {
        private BinaryFormatter bf;
        private FileStream fs;

        public PropertiesManager()
        {
            bf = new BinaryFormatter();
        }

        public ProgramSettings CurrentSettings
        {
            get
            {
                object settings= Load(DirectoryManager.SettingsFileName);
                return settings!=null ? (ProgramSettings)settings : new ProgramSettings();
            }
        }

        public ProgramSetup CurrentSetup
        {
            get
            {
                object setup= Load(DirectoryManager.SetupFileName);
                return setup!=null ? (ProgramSetup)setup : new ProgramSetup();
            }
        }

        public void SaveSettings(ProgramSettings newSettings) { Save(DirectoryManager.SettingsFileName,newSettings); }

        public void SaveSetup(ProgramSetup newSetup) { Save(DirectoryManager.SetupFileName,newSetup); }

        private object Load(string fileName)
        {
            try
            {
                using(fs = new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
                {
                    Stream stream = fs;
                    FileInfo settingsFile = new FileInfo(fileName);
                    if(settingsFile.Exists)
                        return bf.Deserialize(stream);
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("");
            }
            return null;
        }

        private void Save(string fileName, object data)
        {
            if(File.Exists(fileName))
                File.Delete(fileName);
            using(fs = new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
            {
                fs.Seek(0,SeekOrigin.Begin);
                using(Stream stream = fs)
                {
                    bf.Serialize(stream,data);
                }
            }
        }

    }
}
