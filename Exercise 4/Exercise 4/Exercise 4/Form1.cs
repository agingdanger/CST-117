using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This work is my own for CST 117
// Charles Henderson
// 6/3/2018
//
//
namespace Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double seconds, hours, minutes, days;

            if (double.TryParse(textSeconds.Text, out seconds))
                {

                if (seconds < 60)
                {
                    MessageBox.Show("Enter at least 60 seconds");
                }
                else if (seconds >= 60 && seconds <= 3600)
                {
                    minutes = (seconds / 60);
                    labelOutputMinutes.Text = minutes.ToString("n2");

             
                }
                else if (seconds > 3600 && seconds <= 86400)
                {
                    minutes = (seconds / 60);
                    labelOutputMinutes.Text = minutes.ToString("n2");

                    hours = ((seconds / 60) / 60);
                    labelOutputHours.Text = hours.ToString("n2");
                }
                else if (seconds > 86400)
                {
                    minutes = (seconds / 60);
                    labelOutputMinutes.Text = minutes.ToString("n2");

                    hours = ((seconds / 60) / 60);
                    labelOutputHours.Text = hours.ToString("n2");

                    days = (((seconds / 60) / 60) / 24);
                    labelOutputDays.Text = days.ToString("n2");
                }
            }
            else
            {
                MessageBox.Show("Enter a correct value.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
