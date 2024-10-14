using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomreaktor
{
    public partial class Form1 : Form
    {
        int homerseklet = 0;
        int energia = 0;
        bool online;
        public Form1()
        {
            InitializeComponent();
            kiiratasHomerseklet.Text = homerseklet.ToString();
            kiiratasHomerseklet.Text = energia.ToString();
        }

        private void beinditas_Click(object sender, EventArgs e)
        {
            online = true;
            Random r = new Random();
            homerseklet = r.Next(40, 101);
            kiiratasHomerseklet.Text = homerseklet.ToString();
            kiiratasHomerseklet.Text = energia.ToString();
        }

        private void leallitas_Click(object sender, EventArgs e)
        {
            if (homerseklet < 70)
            {
                online = false;
                MessageBox.Show("A reaktor sikeresn leállt!");
            }
            else {
                MessageBox.Show("Túl magas a hőmrérséklet. Kérlek, hűtsd le a reaktort!");
            }
        }

        private void generaltEnergiaMennyiseg_Click(object sender, EventArgs e)
        {

        }

        private void hofok_Click(object sender, EventArgs e)
        {

        }

        private void hutovizBeengedese_Click(object sender, EventArgs e)
        {
            homerseklet = 40;
            MessageBox.Show("Hűtővíz beengedése...");
        }

        private void kiiratasHomerseklet_TextChanged(object sender, EventArgs e)
        {

        }

        private void kiiratasGeneraltEnergia_TextChanged(object sender, EventArgs e)
        {

        }

        private void kiiratasHomerseklet_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
