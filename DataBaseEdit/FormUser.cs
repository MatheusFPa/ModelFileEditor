using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseEdit
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            data();
        }

        private void buttonUserEnter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableButton()
        {
            if (textBoxUser.Text.Length >= 5)
            {
                buttonUserEnter.Enabled = true;
                labelStatusUser.Text = "usuario ok";
            }

            else
                labelStatusUser.Text = "Usuário Inválido, \nMínimo 5 caracteres";
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void data()
        {

            DateTime today = DateTime.Today;
            
            textBoxData.Text = today.ToString("yyyyMMdd"); 
        }
    }
}
