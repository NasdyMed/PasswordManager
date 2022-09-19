using PasswordManager.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PasswordManager.Helper
{
    public static class DatabaseHelper
    {

        public static void SaveDatabase(string path,Database database)
        {
            var filename = Guid.NewGuid().ToString() + ".tmp";
            var tmpFilePath = Path.Combine(Path.GetTempPath(), filename);
            File.WriteAllText(tmpFilePath, JsonSerializer.Serialize(database));


            File.WriteAllText(path, database.Hash);
            //Security.EncryptFile(database.Hash, tmpFilePath, path);
            File.Delete(tmpFilePath);
        }
    }
}
