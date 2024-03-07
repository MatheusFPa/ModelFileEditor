using System;
using System.Windows.Forms;

namespace DataBaseEdit
{
    public partial class FormUser : Form
    {
        FormApp frmApp = FormApp.getInstance();
        public FormUser()
        {
            InitializeComponent();
            data();
        }

        private void buttonUserEnter_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text.Length == 8)
            {
                frmApp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário Inválido");
                textBoxUser.Text = "";
            }
        }
        private void data()
        {

            DateTime today = DateTime.Today;

            textBoxData.Text = today.ToString("yyyyMMdd");
        }
    }
}
