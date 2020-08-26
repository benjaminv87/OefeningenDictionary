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

    public partial class FormVoegWoordenToe : Form
    {
        public FormVoegWoordenToe()
        {
            InitializeComponent();
        }
        public string nederlands, engels, spaans, frans, duits, zweeds, keltisch;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbNL.Text != "" && tbEn.Text != "" && tbEs.Text != "" && tbFr.Text != "" && tbD.Text != "" && tbSw.Text != "" && tbKelt.Text != "")
            {
                nederlands = tbNL.Text;
                engels = tbEn.Text;
                spaans = tbEs.Text;
                frans = tbFr.Text;
                duits = tbD.Text;
                zweeds = tbSw.Text;
                keltisch = tbKelt.Text;
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Vul alle velden in!");
        }
    }
}
