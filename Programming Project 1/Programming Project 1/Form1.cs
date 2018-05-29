using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double jelly, koala, jratio, kratio;

                jelly = double.Parse(textKoala.Text);

                koala = double.Parse(textJelly.Text);

                jratio = jelly / koala;

                kratio = koala / jelly;

                labelOutput.Text = jratio.ToString("n3");
                labelOutput2.Text = kratio.ToString("n3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textKoala.Text = "";
            textJelly.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureKoala_Click(object sender, EventArgs e)
        {
            labelWe.Text = "We";
        }

        private void pictureJelly_Click(object sender, EventArgs e)
        {
            labelFancy.Text = "Fancy";
        }
    }
}
