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
    public partial class FormOef3 : Form
    {
        public FormOef3()
        {
            InitializeComponent();
        }

        public Dictionary<string, Dictionary<string, string>> mijnWoordenboek = new Dictionary<string, Dictionary<string, string>>();

        public Dictionary<string, string> vertalingen(string engels, string spaans, string frans, string duits, string zweeds, string keltisch)
        {
            Dictionary<string, string> woorden = new Dictionary<string, string>();
            woorden.Add("engels", engels);
            woorden.Add("spaans", spaans);
            woorden.Add("frans", frans);
            woorden.Add("duits", duits);
            woorden.Add("zweeds", zweeds);
            woorden.Add("keltisch", keltisch);
            return woorden;
        }
        private void FormOef3_Load(object sender, EventArgs e)
        {

            mijnWoordenboek.Add("scherm", vertalingen("screen", "pantalla", "écran", "bildschirm", "skärm", "scrion"));
            mijnWoordenboek.Add("boek", vertalingen("book", "libro", "livre", "buch", "bok", "Leabhar"));
            mijnWoordenboek.Add("toetsenbord", vertalingen("keyboard", "teclado", "clavier", "tastatur", "tangentbord", "meur-chlàr"));

            cbGeselecteerdeTaal.Items.Add("engels");
            cbGeselecteerdeTaal.Items.Add("spaans");
            cbGeselecteerdeTaal.Items.Add("frans");
            cbGeselecteerdeTaal.Items.Add("duits");
            cbGeselecteerdeTaal.Items.Add("zweeds");
            cbGeselecteerdeTaal.Items.Add("keltisch");
            cbGeselecteerdeTaal.SelectedIndex = 0;
            updateComboBox();
        }

        private void cbTeVertalen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeVertalen.DataSource != null && cbTeVertalen.SelectedIndex > -1)
            {
                KeyValuePair<string, Dictionary<string, string>> pair = (KeyValuePair<string, Dictionary<string, string>>)cbTeVertalen.SelectedItem;
                Dictionary<string, string> Dictionary2 = (Dictionary<string, string>)pair.Value;
                tbVertaald.Text = Dictionary2[cbGeselecteerdeTaal.Text];
            }
            else tbVertaald.Text = string.Empty;
            btnVerwijder.Enabled = cbTeVertalen.SelectedIndex > -1 ? true : false;


        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {

            if (cbTeVertalen.SelectedIndex > -1)
            {
                KeyValuePair<string, Dictionary<string, string>> pair = (KeyValuePair<string, Dictionary<string,string>>)cbTeVertalen.SelectedItem;
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
            using (FormVoegWoordenToe form = new FormVoegWoordenToe())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    mijnWoordenboek.Add(form.nederlands,vertalingen(form.engels,form.spaans,form.frans,form.duits,form.zweeds,form.keltisch));
                    updateComboBox();
                }
            }
        }

        private void cbGeselecteerdeTaal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeVertalen.DataSource != null && cbTeVertalen.SelectedIndex > -1)
            {
                KeyValuePair<string, Dictionary<string, string>> pair = (KeyValuePair<string, Dictionary<string, string>>)cbTeVertalen.SelectedItem;
                Dictionary<string, string> Dictionary2 = (Dictionary<string, string>)pair.Value;
                tbVertaald.Text = Dictionary2[cbGeselecteerdeTaal.Text];
            }
            else tbVertaald.Text = string.Empty;
            btnVerwijder.Enabled = cbTeVertalen.SelectedIndex > -1 ? true : false;
        }
    }
}
