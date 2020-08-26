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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            FormOef1 oefening = new FormOef1();
            oefening.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormOef2 oefening = new FormOef2();
            oefening.Show();
        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            FormOef3 oefening = new FormOef3();
            oefening.Show();
        }

        private void btnOef4_Click(object sender, EventArgs e)
        {
            FormOef4 oefening = new FormOef4();
            oefening.Show();
        }
    }
}
