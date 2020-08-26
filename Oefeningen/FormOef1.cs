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
    public partial class FormOef1 : Form
    {
        public FormOef1()
        {
            InitializeComponent();
        }
        public Dictionary<int, string> mijnGetallen = new Dictionary<int, string>();
        private void FormOef1_Load(object sender, EventArgs e)
        {

            mijnGetallen.Add(1, "één");
            mijnGetallen.Add(2, "twee");
            mijnGetallen.Add(3, "drie");
            mijnGetallen.Add(4, "vier");
            mijnGetallen.Add(5, "vijf");
            mijnGetallen.Add(6, "zes");
            mijnGetallen.Add(7, "zeven");
            mijnGetallen.Add(8, "acht");
            mijnGetallen.Add(9, "negen");
            mijnGetallen.Add(10, "Tien");

            cbMijnGetallen.DataSource = new BindingSource(mijnGetallen, null);
            cbMijnGetallen.DisplayMember = "Key";
            cbMijnGetallen.ValueMember = "Value";


        }

        private void cbMijnGetallen_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> pair = (KeyValuePair<int, string>)cbMijnGetallen.SelectedItem;

            lblGetal.Text = pair.Value;
        }
    }
}
