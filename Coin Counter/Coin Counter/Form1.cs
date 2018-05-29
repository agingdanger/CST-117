using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Counter
{
    public partial class Form1 : Form
    {

       private double total = 0;
      
           
            public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonNickel_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.Blue;
                total += .05;
                labelOutput.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.Green;
                total += .10;
                labelOutput.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.IndianRed;
                total += .25;
                labelOutput.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHalfDollar_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.MediumPurple;
                total += .50;
                labelOutput.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
