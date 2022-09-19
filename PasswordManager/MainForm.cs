using PasswordManager.Entity;
using PasswordManager.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainForm : Form
    {

        public Configuration Configuration;
        public Database Database;

        
        public MainForm()
        {
            InitializeComponent();
            Database = new Database();
            Configuration = new Configuration();
        }

        private void copierLeNomDeLutilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewDatabse(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Base de données.mpm";
            sfd.Filter = "Ficher MPM de Base de données | *.mpm";


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                NewDatabaseForm newDatabaseForm = new NewDatabaseForm();


                if (newDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database.Entries = new BindingList<Entry>();
                    DtgEntries.DataSource = Database.Entries;
                    Configuration.LastUsedFile = dbFile;
                    DatabaseHelper.SaveDatabase(dbFile,Database);
                    Text = $"PasswordManager - {Path.GetFileName(dbFile)}";
                }

            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationHelper.SaveConfiguration(Configuration);
        }
    }
}
