using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Entity
{
    public class Database
    {
        public BindingList<Entry> Entries { get; set; }
        public string Hash { get; set; }

        public Database()
        {
            Entries = new BindingList<Entry>();
        }
    }
}
