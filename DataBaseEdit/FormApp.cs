using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataBaseEdit
{
    public partial class FormApp : Form
    {

        Actions act;
        private static FormApp INSTANCE = null;

        public FormApp()
        {
            INSTANCE = this;
            InitializeComponent();
            ClassInit();
        }
        public static FormApp getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormApp();

            return INSTANCE;
        }
        private void ClassInit()
        {
            act = new Actions();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBoxProduct.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            groupBoxProduct.Visible = false;
        }

        private void buttonColuna_Click(object sender, EventArgs e)
        {
            groupBoxColumnEdit.Visible = true;
        }

        private void buttonSaveColumn_Click(object sender, EventArgs e)
        {
            groupBoxColumnEdit.Visible = false;
        }

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            if (openFileDialogDirect.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectory.Text = openFileDialogDirect.FileName;
                buttonBackUp.Enabled = true;
            }
        }

        public void buttonBackUp_Click(object sender, EventArgs e)
        {
            act.BackUp(openFileDialogDirect.FileName);
        }
    }
}
