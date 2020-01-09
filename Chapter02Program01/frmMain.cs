using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02Program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        [STAThread]
        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnDisplayOuput_Click(object sender, EventArgs e)
        {
            String buffer;
            buffer = "Mailing Label:" + Environment.NewLine +
                Environment.NewLine;
            buffer = buffer + "Name:" + txtName.Text +
                Environment.NewLine;
            buffer = buffer + "Address:" + txtAddress.Text +
                Environment.NewLine;
            buffer = buffer + "City:" + txtCity.Text +
                Environment.NewLine;
            buffer = buffer + "State:" + txtState.Text +
                Environment.NewLine;
            buffer = buffer + "ZIP:" + txtZIP.Text +
                Environment.NewLine;
            txtDisplayOutput.Text = buffer;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
