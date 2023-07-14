using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opc_Reader_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool workering = false;
        private void mainWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void mainWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void mainWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btnStartRead_Click(object sender, EventArgs e)
        {
            if (workering)
            {
                btnStartRead.Text = "Okumka Durdur";
            }
            else
            {
                btnStartRead.Text = "Okumka Başla";
            }
        }
    }
}
