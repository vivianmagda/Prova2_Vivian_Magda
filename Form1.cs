using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2_Vivian_Magda
{
    public partial class EnergiaEletrica : Form
    {

        double residencial_1 = 0.40,
                residencial_2 = 0.65,
                comercial_1 = 0.55,
                comercial_2 = 0.60,
                industrial_1 = 0.55,
                industrial_2 = 0.60,
                pagar;
        double consumo;

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            consumo = Convert.ToDouble(textBox1.Text);

            if (btR.Visible)
            {
                if (consumo <= 500)
                    pagar = consumo * residencial_1;
                else
                    pagar = consumo * residencial_2;
                MessageBox.Show(Convert.ToString(pagar));
            }
            else if (btC.Visible)
            {
                if (consumo <= 1000)
                    pagar = consumo * comercial_1;
                else
                    pagar = consumo * comercial_2;
                MessageBox.Show(Convert.ToString(pagar));
            }
            else
            {
                if (consumo <= 5000)
                    pagar = consumo * industrial_1;
                else
                    pagar = consumo * industrial_2;
                MessageBox.Show(Convert.ToString(pagar));
            }
                               
        }

        public EnergiaEletrica()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            btVoltar.Hide();
            label1.Hide();
            textBox1.Hide();
            btRelatorio.Hide();

            btI.Show();
            btC.Show();
            btR.Show();
            btSair.Show();            

            btC.Location = new System.Drawing.Point(149, 166);
            btI.Location = new System.Drawing.Point(149, 233);
        }

        private void btR_Click(object sender, EventArgs e)
        {
            btC.Hide();
            btI.Hide();
            btVoltar.Show();
            btSair.Hide();
            label1.Show();
            textBox1.Show();
            btRelatorio.Show();

        }

        private void btI_Click(object sender, EventArgs e)
        {
            btC.Hide();
            btR.Hide();
            btI.Location = btR.Location;
            btSair.Hide();
            btVoltar.Show();
            label1.Show();
            textBox1.Show();
            btRelatorio.Show();
        }

        private void btC_Click(object sender, EventArgs e)
        {
            btR.Hide();
            btI.Hide();
            btC.Location = btR.Location;
            btSair.Hide();
            btVoltar.Show();
            label1.Show();
            textBox1.Show();
            btRelatorio.Show();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
