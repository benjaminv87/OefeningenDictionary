using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefeningen
{
    public partial class FormVoegWoordToe : Form
    {
        public FormVoegWoordToe()
        {
            InitializeComponent();
        }
        public string nederlands, engels; 

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbEngels.Text != "" && tbNederlands.Text != "")
            {
                nederlands = tbNederlands.Text;
                engels = tbEngels.Text;
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Vul alle vakken in");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
