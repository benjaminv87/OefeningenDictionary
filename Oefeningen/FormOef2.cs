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
    public partial class FormOef2 : Form
    {
        public FormOef2()
        {
            InitializeComponent();
        }
        public Dictionary<string, string> mijnWoordenboek = new Dictionary<string, string>();
        private void FormOef2_Load(object sender, EventArgs e)
        {
            mijnWoordenboek.Add("boek", "book");
            mijnWoordenboek.Add("scherm", "screen");
            mijnWoordenboek.Add("muis", "mouse");
            mijnWoordenboek.Add("toetsenbord", "keyboard");
            mijnWoordenboek.Add("cursus", "course");
            mijnWoordenboek.Add("telefoon", "phone");

            updateComboBox();
        }

        private void cbTeVertalen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeVertalen.DataSource != null && cbTeVertalen.SelectedIndex>-1)
            {
                KeyValuePair<string, string> pair = (KeyValuePair<string, string>)cbTeVertalen.SelectedItem;
                tbVertaald.Text = pair.Value;
            }
            else tbVertaald.Text = string.Empty;
            btnVerwijder.Enabled = cbTeVertalen.SelectedIndex > -1 ? true:false;
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {

            if (cbTeVertalen.SelectedIndex > -1)
            {
                KeyValuePair<string, string> pair = (KeyValuePair<string, string>)cbTeVertalen.SelectedItem;
                mijnWoordenboek.Remove(pair.Key);
                updateComboBox();
            }
        }

        private void updateComboBox()
        {
            if (mijnWoordenboek.Count > 0)
            {
                cbTeVertalen.DataSource = new BindingSource(mijnWoordenboek, null);
                cbTeVertalen.DisplayMember = "Key";
                cbTeVertalen.ValueMember = "Value";
            }
            else cbTeVertalen.DataSource = null;
            cbTeVertalen.SelectedIndex = -1;
        }

        private void btnWoordToevoegen_Click(object sender, EventArgs e)
        {
            using(FormVoegWoordToe form = new FormVoegWoordToe())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    mijnWoordenboek.Add(form.nederlands,form.engels);
                    updateComboBox();
                }
            }
        }
    }
}
