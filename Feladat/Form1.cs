using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_rogzit_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_rendszam.Text.Trim()))
            {
                MessageBox.Show("Nem adta meg a rendszámot!", "Hibás adat!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (String.IsNullOrEmpty(combobox_tipus.Text))
            {
                MessageBox.Show("Nem választotta ki a típust!", "Hibás adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Auto auto = new Auto(textBox_rendszam.Text,combobox_tipus.Text,(int)numericUpDown_gyartmany.Value,(int)numericUpDown_teljesitmeny.Value,checkBox_kombi.Checked,checkBox_cabrio.Checked,checkBox_haromajto.Checked);
            listBox_auto.Items.Add(textBox_rendszam.Text);
        }

        private void listBox_auto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Auto valasztottauto = (Auto)listBox_auto.Items[listBox_auto.SelectedIndex];
            textBox_rendszam.Text = valasztottauto.Rendszam;
            //combobox_tipus.SelectedItem = auto.Tipus;


        }
    }
}
