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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // groupBoxProduct.Visible = false;
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

    }
}
