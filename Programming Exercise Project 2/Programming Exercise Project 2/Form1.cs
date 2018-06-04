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
//Charles Henderson
//6.3.2018
namespace Programming_Exercise_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPicture.SelectedIndex != -1)
            {
                if (listPicture.SelectedIndex == 0)
                {
                    pictureLighthouse.Visible = true;
                    if (listPicture.SelectedIndex == 0 && radioFont1.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        if (listPicture.SelectedIndex == 0 && radioFont1.Checked && checkBold.Checked)
                        {
                            labelOutput.Text = "Lighthouse";
                            labelOutput.Font = new Font("Segoe print", 15);
                            labelOutput.Font = new Font("Segoe print", 15, FontStyle.Bold);
                        }
                    }

                    if (listPicture.SelectedIndex == 0 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Segoe print", 15);
                        labelOutput.Font = new Font("Segoe print", 15, FontStyle.Bold);
                    }

                    if (listPicture.SelectedIndex == 0 && radioFont2.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Webdings", 15);
                        if (listPicture.SelectedIndex == 0 && radioFont2.Checked && checkBold.Checked)
                        {
                            labelOutput.Text = "Lighthouse";
                            labelOutput.Font = new Font("Webdings", 15);
                            labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        }
                    }

                    if (listPicture.SelectedIndex == 0 && radioFont2.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        if (listPicture.SelectedIndex == 0 && radioFont2.Checked && checkBold.Checked)
                        {
                            labelOutput.Text = "Lighthouse";
                            labelOutput.Font = new Font("Webdings", 15);
                            labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        }
                    }

                    if (listPicture.SelectedIndex == 0 && radioFont3.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Verdana", 15);
                        if (listPicture.SelectedIndex == 0 && radioFont3.Checked && checkBold.Checked)
                        {
                            labelOutput.Text = "Lighthouse";
                            labelOutput.Font = new Font("Verdana", 15);
                            labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                        }
                    }

                    if (listPicture.SelectedIndex == 0 && radioFont3.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                    }

                    if (listPicture.SelectedIndex == 0 && radioFont4.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Font = new Font("Impact", 15, FontStyle.Bold);
                    }

                    if (listPicture.SelectedIndex == 0 && radioFont4.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Impact", 15);
                    }


                    if (listPicture.SelectedIndex == 0 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Lighthouse";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    }

                }
                if (listPicture.SelectedIndex == 1)
                {
                    pictureKoala.Visible = true;
                    if (listPicture.SelectedIndex == 1 && radioFont1.Checked)
                    {

                        pictureKoala.Visible = true;
                        labelOutput.Text = "Koala";
                        labelOutput.Font = new Font("Segoe Print", 15);
                    }

                    if (listPicture.SelectedIndex == 1 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Koala";
                        labelOutput.Font = new Font("Segoe print", 15);
                        labelOutput.Font = new Font("Segoe print", 15, FontStyle.Bold);
                    }

                    if (listPicture.SelectedIndex == 1 && radioFont2.Checked)
                    {
                        pictureKoala.Visible = true;
                        labelOutput.Text = "Koala";
                        labelOutput.Font = new Font("Webdings", 15);
                    }

                    if (listPicture.SelectedIndex == 1 && radioFont2.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Koala";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    }

                    if (listPicture.SelectedIndex == 1 && radioFont3.Checked)
                    {
                        pictureKoala.Visible = true;
                        labelOutput.Text = "Koala";
                        labelOutput.Font = new Font("Verdana", 15);
                    }

                    if (listPicture.SelectedIndex == 1 && radioFont3.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Koala";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                    }

                    if (listPicture.SelectedIndex == 1 && radioFont4.Checked)
                    {
                        pictureKoala.Visible = true;
                        labelOutput.Text = "Koala";
                        labelOutput.Font = new Font("Impact", 15);
                    }

                    if (listPicture.SelectedIndex == 1 && radioFont4.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Koala";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Font = new Font("Impact", 15, FontStyle.Bold);
                    }

                }

                if (listPicture.SelectedIndex == 2)
                {
                    pictureJellyfish.Visible = true;
                    if (listPicture.SelectedIndex == 2 && radioFont1.Checked)
                    {
                        labelOutput.Text = "Jellyfish";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        labelOutput.Text = "Jellyfish";
                    }

                    if (listPicture.SelectedIndex == 2 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Jellyfish";
                        labelOutput.Font = new Font("Segoue Print", 15);
                        labelOutput.Font = new Font("Segoue Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Jellyfish";
                    }

                    if (listPicture.SelectedIndex == 2 && radioFont2.Checked)
                    {
                        labelOutput.Text = "Jellyfish";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Text = "Jellyfish";
                    }

                    if (listPicture.SelectedIndex == 2 && radioFont2.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Jellyfish";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        labelOutput.Text = "Jellyfish";
                    }

                    if (listPicture.SelectedIndex == 2 && radioFont3.Checked)
                    {
                        labelOutput.Text = "Jellyfish";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Text = "Jellyfish";
                    }

                    if (listPicture.SelectedIndex == 2 && radioFont3.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Jellyfish";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                        labelOutput.Text = "Jellyfish";
                    }

                    if (listPicture.SelectedIndex == 2 && radioFont4.Checked)
                    {
                        labelOutput.Text = "Jellyfish";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Text = "Jellyfish";
                    }

                    if (listPicture.SelectedIndex == 2 && radioFont4.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Jellyfish";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Font = new Font("Impact", 15, FontStyle.Bold);
                        labelOutput.Text = "Jellyfish";
                    }

                }

                if (listPicture.SelectedIndex == 3)
                {
                    picturePenguins.Visible = true;
                    if (listPicture.SelectedIndex == 3 && radioFont1.Checked)
                    {
                        labelOutput.Text = "Penguins";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        labelOutput.Text = "Penguins";
                    }

                    if (listPicture.SelectedIndex == 3 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Penguins";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Penguins";
                    }

                    if (listPicture.SelectedIndex == 3 && radioFont2.Checked)
                    {
                        labelOutput.Text = "Penguins";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Text = "Penguins";
                    }

                    if (listPicture.SelectedIndex == 3 && radioFont2.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Penguins";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        labelOutput.Text = "Penguins";
                    }

                    if (listPicture.SelectedIndex == 3 && radioFont3.Checked)
                    {
                        labelOutput.Text = "Penguins";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Text = "Penguins";
                    }

                    if (listPicture.SelectedIndex == 3 && radioFont3.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Penguins";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                        labelOutput.Text = "Penguins";
                    }

                    if (listPicture.SelectedIndex == 3 && radioFont4.Checked)
                    {
                        labelOutput.Text = "Penguins";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Text = "Penguins";
                    }

                    if (listPicture.SelectedIndex == 3 && radioFont4.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Penguins";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Font = new Font("Impact", 15, FontStyle.Bold);
                        labelOutput.Text = "Penguins";
                    }

                }

                if (listPicture.SelectedIndex == 4)
                {
                    pictureFlowers.Visible = true;
                    if (listPicture.SelectedIndex == 4 && radioFont1.Checked)
                    {
                        labelOutput.Text = "Flowers";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        labelOutput.Text = "Flowers";
                    }

                    if (listPicture.SelectedIndex == 4 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Flowers";
                        labelOutput.Font = new Font("Segoue Print", 15);
                        labelOutput.Font = new Font("Segoue Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Flowers";
                    }

                    if (listPicture.SelectedIndex == 4 && radioFont2.Checked)
                    {
                        labelOutput.Text = "Flowers";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Text = "Flowers";
                    }

                    if (listPicture.SelectedIndex == 4 && radioFont2.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Flowers";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        labelOutput.Text = "Flowers";
                    }

                    if (listPicture.SelectedIndex == 4 && radioFont3.Checked)
                    {
                        labelOutput.Text = "Flowers";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Text = "Flowers";
                    }

                    if (listPicture.SelectedIndex == 4 && radioFont3.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Flowers";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                        labelOutput.Text = "Flowers";
                    }

                    if (listPicture.SelectedIndex == 4 && radioFont4.Checked)
                    {
                        labelOutput.Text = "Flowers";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Text = "Flowers";
                    }

                    if (listPicture.SelectedIndex == 4 && radioFont4.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Flowers";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Font = new Font("Impact", 15, FontStyle.Bold);
                        labelOutput.Text = "Flowers";
                    }

                }

                if (listPicture.SelectedIndex == 5)
                {
                    pictureFlower.Visible = true;
                    if (listPicture.SelectedIndex == 5 && radioFont1.Checked)
                    {
                        labelOutput.Text = "Flower";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        labelOutput.Text = "Flower";
                    }

                    if (listPicture.SelectedIndex == 5 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Flower";
                        labelOutput.Font = new Font("Segoue Print", 15);
                        labelOutput.Font = new Font("Segoue Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Flower";
                    }

                    if (listPicture.SelectedIndex == 5 && radioFont2.Checked)
                    {
                        labelOutput.Text = "Flower";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Text = "Flower";
                    }

                    if (listPicture.SelectedIndex == 5 && radioFont2.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Flower";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        labelOutput.Text = "Flower";
                    }

                    if (listPicture.SelectedIndex == 5 && radioFont3.Checked)
                    {
                        labelOutput.Text = "Flower";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Text = "Flower";
                    }

                    if (listPicture.SelectedIndex == 5 && radioFont3.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Flower";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                        labelOutput.Text = "Flower";
                    }

                    if (listPicture.SelectedIndex == 5 && radioFont4.Checked)
                    {
                        labelOutput.Text = "Flower";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Text = "Flower";
                    }

                    if (listPicture.SelectedIndex == 5 && radioFont4.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Flower";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Font = new Font("Impact", 15, FontStyle.Bold);
                        labelOutput.Text = "Flower";
                    }

                }

                if (listPicture.SelectedIndex == 6)
                {
                    pictureWeirderFlowers.Visible = true;
                    if (listPicture.SelectedIndex == 6 && radioFont1.Checked)
                    {
                        labelOutput.Text = "Weirder Flowers";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        labelOutput.Text = "Weirder Flowers";
                    }

                    if (listPicture.SelectedIndex == 6 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Weirder Flowers";
                        labelOutput.Font = new Font("Segoue Print", 15);
                        labelOutput.Font = new Font("Segoue Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Weirder Flowers";
                    }

                    if (listPicture.SelectedIndex == 6 && radioFont2.Checked)
                    {
                        labelOutput.Text = "Weirder Flowers";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Text = "Weirder Flowers";
                    }

                    if (listPicture.SelectedIndex == 6 && radioFont2.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Weirder Flowers";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        labelOutput.Text = "Weirder Flowers";
                    }

                    if (listPicture.SelectedIndex == 6 && radioFont3.Checked)
                    {
                        labelOutput.Text = "Weirder Flowers";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Text = "Weirder Flowers";
                    }

                    if (listPicture.SelectedIndex == 6 && radioFont3.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Weirder Flowers";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                        labelOutput.Text = "Weirder Flowers";
                    }

                    if (listPicture.SelectedIndex == 6 && radioFont4.Checked)
                    {
                        labelOutput.Text = "Weirder Flowers";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Text = "Weirder Flowers";
                    }

                    if (listPicture.SelectedIndex == 6 && radioFont4.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Weirder Flowers";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Font = new Font("Impact", 15, FontStyle.Bold);
                        labelOutput.Text = "Weirder Flowers";
                    }

                }

                if (listPicture.SelectedIndex == 7)
                {
                    pictureDesert.Visible = true;
                    if (listPicture.SelectedIndex == 7 && radioFont1.Checked)
                    {
                        labelOutput.Text = "Desert";
                        labelOutput.Font = new Font("Segoe Print", 15);
                        labelOutput.Text = "Desert";
                    }

                    if (listPicture.SelectedIndex == 7 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Desert";
                        labelOutput.Font = new Font("Segoue Print", 15);
                        labelOutput.Font = new Font("Segoue Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Desert";
                    }

                    if (listPicture.SelectedIndex == 7 && radioFont2.Checked)
                    {
                        labelOutput.Text = "Desert";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Text = "Desert";
                    }

                    if (listPicture.SelectedIndex == 7 && radioFont2.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Desert";
                        labelOutput.Font = new Font("Webdings", 15);
                        labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                        labelOutput.Text = "Desert";
                    }

                    if (listPicture.SelectedIndex == 7 && radioFont3.Checked)
                    {
                        labelOutput.Text = "Desert";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Text = "Desert";
                    }

                    if (listPicture.SelectedIndex == 7 && radioFont3.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Desert";
                        labelOutput.Font = new Font("Verdana", 15);
                        labelOutput.Font = new Font("Verdana", 15, FontStyle.Bold);
                        labelOutput.Text = "Desert";
                    }

                    if (listPicture.SelectedIndex == 7 && radioFont4.Checked)
                    {
                        labelOutput.Text = "Desert";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Text = "Desert";
                    }

                    if (listPicture.SelectedIndex == 7 && radioFont4.Checked && checkBold.Checked)
                    {
                        labelOutput.Text = "Desert";
                        labelOutput.Font = new Font("Impact", 15);
                        labelOutput.Font = new Font("Impact", 15, FontStyle.Bold);
                        labelOutput.Text = "Desert";
                    }

                }
            }
    
        }

        private void radioFont1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFont1.Checked)
            {
                if (radioFont1.Checked && listPicture.SelectedIndex == 0)
                {
                    labelOutput.Text = "Lighthouse";
                    labelOutput.Font = new Font("Segoe Print", 15);
                    labelOutput.Text = "Lighthouse";
                    if (listPicture.SelectedIndex == 0 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Lighthouse";
                    }
                }

                if (listPicture.SelectedIndex == 0 && radioFont1.Checked && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    labelOutput.Text = "Lighthouse";
                }



                if (radioFont1.Checked && listPicture.SelectedIndex == 1)
                {
                    labelOutput.Text = "Koala";
                    labelOutput.Font = new Font("Segoe Print", 15);
                    labelOutput.Text = "Koala";
                    if (listPicture.SelectedIndex == 1 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Koala";
                    }
                }

                if (listPicture.SelectedIndex == 1 && radioFont1.Checked && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    labelOutput.Text = "Koala";
                }


                if (radioFont1.Checked && listPicture.SelectedIndex == 2)
                {
                    labelOutput.Text = "Jellyfish";
                    labelOutput.Font = new Font("Segoe Print", 15);
                    labelOutput.Text = "Jellyfish";
                    if (listPicture.SelectedIndex == 2 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Jellyfish";
                    }
                }

                if (listPicture.SelectedIndex == 2 && radioFont1.Checked && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    labelOutput.Text = "Jellyfish";
                }

                if (radioFont1.Checked && listPicture.SelectedIndex == 3)
                {
                    labelOutput.Text = "Penguin";
                    labelOutput.Font = new Font("Segoe Print", 15);
                    labelOutput.Text = "Penguin";
                    if (listPicture.SelectedIndex == 3 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Penguin";
                    }
                }

                if (listPicture.SelectedIndex == 3 && radioFont1.Checked && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    labelOutput.Text = "Penguin";
                }

                if (radioFont1.Checked && listPicture.SelectedIndex == 4)
                {
                    labelOutput.Text = "Flowers";
                    labelOutput.Font = new Font("Segoe Print", 15);
                    labelOutput.Text = "Flowers";
                    if (listPicture.SelectedIndex == 4 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Flowers";
                    }
                }

                if (listPicture.SelectedIndex == 4 && radioFont1.Checked && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    labelOutput.Text = "Flowers";
                }

                if (radioFont1.Checked && listPicture.SelectedIndex == 5)
                {
                    labelOutput.Text = "Flower";
                    labelOutput.Font = new Font("Segoe Print", 15);
                    labelOutput.Text = "Flower";
                    if (listPicture.SelectedIndex == 5 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Flower";
                    }
                }

                if (listPicture.SelectedIndex == 5 && radioFont1.Checked && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    labelOutput.Text = "Flower";
                }

                if (radioFont1.Checked && listPicture.SelectedIndex == 6)
                {
                    labelOutput.Text = "Weirder Flowers";
                    labelOutput.Font = new Font("Segoe Print", 15);
                    labelOutput.Text = "Weirder Flowers";
                    if (listPicture.SelectedIndex == 6 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Weirder Flowers";
                    }
                }
                if (listPicture.SelectedIndex == 6 && radioFont1.Checked && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    labelOutput.Text = "Weirder Flowers";
                }


                if (radioFont1.Checked && listPicture.SelectedIndex == 7)
                {
                    labelOutput.Text = "Desert";
                    labelOutput.Font = new Font("Segoe Print", 15);
                    labelOutput.Text = "Desert";
                    if (listPicture.SelectedIndex == 7 && radioFont1.Checked && checkBold.Checked)
                    {
                        labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                        labelOutput.Text = "Desert";
                    }
                }

                if (listPicture.SelectedIndex == 7 && radioFont1.Checked && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                    labelOutput.Text = "Desert";
                }
            }

        }

        private void radioFont2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioFont2.Checked)
            {
                if (radioFont2.Checked && listPicture.SelectedIndex == 0)
                {
                    labelOutput.Text = "Lighthouse";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 0 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Lighthouse";
            
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 1)
                {
                    labelOutput.Text = "Koala";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 1 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Koala";

                }


                if (radioFont2.Checked && listPicture.SelectedIndex == 2)
                {
                    labelOutput.Text = "Jellyfish";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 2 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Jellyfish";

                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 3)
                {
                    labelOutput.Text = "Penguin";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 3 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Penguin";

                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 4)
                {
                    labelOutput.Text = "Flowers";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 4 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Flowers";

                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 5)
                {
                    labelOutput.Text = "Flower";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 5 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Flower";

                }


                if (radioFont2.Checked && listPicture.SelectedIndex == 6)
                {
                    labelOutput.Text = "Weirder Flowers";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 6 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Weirder Flowers";

                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 7)
                {
                    labelOutput.Text = "Desert";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont2.Checked && listPicture.SelectedIndex == 7 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Desert";

                }

            }
        }

        private void radioFont3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFont3.Checked)
            {
                if (radioFont3.Checked && listPicture.SelectedIndex == 0)
                {
                    labelOutput.Text = "Lighthouse";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 0 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Lighthouse";

                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 1)
                {
                    labelOutput.Text = "Koala";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 1 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Koala";

                }


                if (radioFont3.Checked && listPicture.SelectedIndex == 2)
                {
                    labelOutput.Text = "Jellyfish";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 2 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Jellyfish";

                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 3)
                {
                    labelOutput.Text = "Penguin";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 3 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Penguin";

                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 4)
                {
                    labelOutput.Text = "Flowers";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 4 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Flowers";

                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 5)
                {
                    labelOutput.Text = "Flower";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 5 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Flower";

                }


                if (radioFont3.Checked && listPicture.SelectedIndex == 6)
                {
                    labelOutput.Text = "Weirder Flowers";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 6 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Weirder Flowers";

                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 7)
                {
                    labelOutput.Text = "Desert";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont3.Checked && listPicture.SelectedIndex == 7 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Desert";

                }

            }
        }

        private void radioFont4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFont4.Checked)
            {
                if (radioFont4.Checked && listPicture.SelectedIndex == 0)
                {
                    labelOutput.Text = "Lighthouse";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 0 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Lighthouse";

                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 1)
                {
                    labelOutput.Text = "Koala";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 1 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Koala";

                }


                if (radioFont4.Checked && listPicture.SelectedIndex == 2)
                {
                    labelOutput.Text = "Jellyfish";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 2 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Jellyfish";

                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 3)
                {
                    labelOutput.Text = "Penguin";
                    labelOutput.Font = new Font("Webdings", 15);
                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 3 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Penguin";

                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 4)
                {
                    labelOutput.Text = "Flowers";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 4 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Flowers";

                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 5)
                {
                    labelOutput.Text = "Flower";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 5 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Flower";

                }


                if (radioFont4.Checked && listPicture.SelectedIndex == 6)
                {
                    labelOutput.Text = "Weirder Flowers";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 6 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Weirder Flowers";

                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 7)
                {
                    labelOutput.Text = "Desert";
                    labelOutput.Font = new Font("Segoe Print", 15);
                }

                if (radioFont4.Checked && listPicture.SelectedIndex == 7 && checkBold.Checked)
                {
                    labelOutput.Font = new Font("Webdings", 15, FontStyle.Bold);
                    labelOutput.Text = "Desert";

                }

            }
        }
    }
}
