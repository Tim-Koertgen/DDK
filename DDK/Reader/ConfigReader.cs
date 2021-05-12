using System;
using System.IO;
using Newtonsoft.Json;

namespace DDK.Reader
{
    public class ConfigReader
    {
        private string _projectDir;
        private string _fileName = ".ddk.json";

        public ConfigReader(string projectDir)
        {
            _projectDir = projectDir;
        }

        public dynamic Read()
        {
            try
            {
                using (StreamReader r = new StreamReader(_projectDir + "/" + _fileName))
                {
                    string json = r.ReadToEnd();
                    dynamic config = JsonConvert.DeserializeObject(json);

                    return config;
                }
            } catch (FileNotFoundException e) {
                Log.Error(e.Message);
                return null;
            }
        }
    }
}
