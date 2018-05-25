//This is my work
// Charles Henderson
//Exercise 3
// 5/25/2018


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sayHi_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            // get age from age box
            string strAge = ageBox.Text;
            // convert from string to integer
            int age = int.Parse(strAge);
            // convert to years left
            int yearsLeft = r.Next(0, 33) + (age % 5);
            // show results
            resultBox.Text = yearsLeft.ToString();
        }

        private void label_results_Click(object sender, EventArgs e)
        {

        }
    }
}
