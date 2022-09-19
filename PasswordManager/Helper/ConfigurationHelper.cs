using System;
using System.Collections.Generic;
using PasswordManager.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace PasswordManager.Helper
{
    public class ConfigurationHelper
    {
        private static readonly string configPathDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PasswordManager");

        private static readonly string configFileName = "PasswordManager.json";
        private static readonly string configFilePath = Path.Combine(configPathDir, configFileName);


        public static void SaveConfiguration(Configuration config)
        {
            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            if (!Directory.Exists(configFilePath))
            {
                Directory.CreateDirectory(configFilePath);
            }

            File.WriteAllText(configFilePath, json);
        }
    }
}
