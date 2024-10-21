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
        Random r = new Random();
        int homerseklet = 40;
        int energia = 0;
        bool online = false;

        public Form1()
        {
            InitializeComponent();
            kiiratasHomerseklet.Text = homerseklet.ToString();
            kiiratasHomerseklet.Text = energia.ToString();
        }

        private void beinditas_Click(object sender, EventArgs e)
        {
            
            if (!online)
            {
                online = true;
                homerseklet = r.Next(40, 101);
                energia = r.Next(1, 11);
                kiiratasHomerseklet.Text = homerseklet.ToString();
                kiiratasGeneraltEnergia.Text = energia.ToString();
                MessageBox.Show("A reaktor elindult!");
            }
            else
            {
                MessageBox.Show("A reaktor már fut!");
            }
        }

        private void leallitas_Click(object sender, EventArgs e)
        {
            if (online)
            {
                if (homerseklet < 70)
                {
                    online = false;
                    kiiratasHomerseklet.Clear();
                    kiiratasGeneraltEnergia.Clear();
                    MessageBox.Show("A reaktor sikeresn leállt!");
                }
                else
                {
                    MessageBox.Show("Túl magas a hőmérséklet. Kérlek, hűtsd le a reaktort!");
                }
            }
            else
            {
                MessageBox.Show("A reaktor nem fut!");
            }
        }

        private void generaltEnergiaMennyiseg_Click(object sender, EventArgs e)
        {
            if (online)
            {
                energia += r.Next(1, 6);
                kiiratasGeneraltEnergia.Text = energia.ToString();
            }
            else
            {
                MessageBox.Show("A reaktor nem termel energiát!");
            }
        }

        private void hofok_Click(object sender, EventArgs e)
        {
            kiiratasHomerseklet.Text = homerseklet.ToString();
        }

        private void hutovizBeengedese_Click(object sender, EventArgs e)
        {
            if (online && homerseklet > 40)
            {
                homerseklet = 40;
                kiiratasHomerseklet.Text = homerseklet.ToString();
                homerseklet = 0;
                MessageBox.Show("A reaktor lehűtve!");
            }
            else
            {
                MessageBox.Show("A reaktor már le van hűtve!");
            }
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
