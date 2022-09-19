using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class NewDatabaseForm : Form
    {
        public NewDatabaseForm()
        {
            InitializeComponent();
        }

        private void NewDatabaseForm_Load(object sender, EventArgs e)
        {

        }

        private void Accept(object sender, EventArgs e)
        {
            if (tbxMasterPassword.Text.Equals(tbxRepeatMasterPassword.Text) && tbxMasterPassword.Text != "")
            {
                ((MainForm)Owner).Database.Hash = Security.GetHash(tbxMasterPassword.Text);
            }else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas !","PasswordManager",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
            
        }

        private void ToggelPasswordChar(object sender, EventArgs e)
        {
            tbxMasterPassword.UseSystemPasswordChar = !tbxMasterPassword.UseSystemPasswordChar;
            tbxRepeatMasterPassword.UseSystemPasswordChar = !tbxRepeatMasterPassword.UseSystemPasswordChar;
        }
    }
}
