using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Entity
{
    public class Entry
    {
        [Browsable(false)]
        public string Uuid { get; set; }

        [DisplayName("Titre")]
        public string Title { get; set; }

        [DisplayName("Utilisateur")]
        public string Username { get; set; }

        [DisplayName("Mot de passe")]
        public string Password { get; set; }

        [DisplayName("Lien")]
        public string Link { get; set; }

        [DisplayName("Date de création")]
        public DateTime CreatedAt { get; set; }
    }
}
