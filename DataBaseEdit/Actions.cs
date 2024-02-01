using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseEdit
{
    class Actions
    {
        FormApp frmApp = FormApp.getInstance();

        public bool BackUp(string fileName)
        {
            try
            {
                File.Copy(fileName, frmApp.textBoxDirectory.Text);
                return true;
            }

            catch
            {
                return false;
            }

        }

    }
}
