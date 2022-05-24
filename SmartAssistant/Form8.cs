using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAssistant
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        string room = "saloni"; 

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void έλεγχοςΣπιτιούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void πλάνοΗμέραςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void φροντίδαΚατοικιδίωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void παπουτσοθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void σαλόνιToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (room != "saloni")
            {
                room = "saloni";
                if (Program.sittinglights == true)
                {
                    this.BackgroundImage = global::SmartAssistant.Properties.Resources.saloni;
                }
                else
                {
                    this.BackgroundImage = global::SmartAssistant.Properties.Resources.salonidark;
                }
                if (Program.radio == true)
                {
                    pictureBox4.Visible = true;
                }
                else
                {
                    pictureBox4.Visible = false;
                }
                if (Program.tv == true)
                {
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

            }
        }

        private void κουζίναToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (room != "kouzina")
            {
                room = "kouzina";
                if (Program.kitchenlights == true)
                {
                    this.BackgroundImage = global::SmartAssistant.Properties.Resources.kitchen;
                }
                else
                {
                    this.BackgroundImage = global::SmartAssistant.Properties.Resources.kitchendark;
                }
                if (Program.plintPiat == true)
                {
                    pictureBox5.Visible = true;
                }
                else
                {
                    pictureBox5.Visible = false;
                }
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
            }
        }

        private void υπνοδωμάτιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (room != "domatio")
            {
                room = "domatio";
                if (Program.bedlights == true)
                {
                    this.BackgroundImage = global::SmartAssistant.Properties.Resources.bedroom;
                }
                else
                {
                    this.BackgroundImage = global::SmartAssistant.Properties.Resources.beddark;
                }
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
        }

        private void μπάνιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (room != "bath")
            {
                room = "bath";
                if (Program.bathlights == true)
                {
                    this.BackgroundImage = global::SmartAssistant.Properties.Resources.bathroom;
                }
                else
                {
                    this.BackgroundImage = global::SmartAssistant.Properties.Resources.bathdark;
                }
                if (Program.plintRoux == true)
                {
                    pictureBox6.Visible = true;
                }
                else
                {
                    pictureBox6.Visible = false;
                }
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
        }

        private void συσκευέςΚαιΦώταToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form3 = new Form3())
            {
                var result = form3.ShowDialog();
                if (result == DialogResult.OK)
                {
                    
                    if (room == "bath")
                    {
                        if (Program.bathlights == true)
                        {
                            this.BackgroundImage = global::SmartAssistant.Properties.Resources.bathroom;
                        }
                        else
                        {
                            this.BackgroundImage = global::SmartAssistant.Properties.Resources.bathdark;
                        }
                        if (Program.plintRoux == true)
                        {
                            pictureBox6.Visible = true;
                        }
                        else
                        {
                            pictureBox6.Visible = false;
                        }
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                    }

                    if (room == "domatio")
                    {
                        if (Program.bedlights == true)
                        {
                            this.BackgroundImage = global::SmartAssistant.Properties.Resources.bedroom;
                        }
                        else
                        {
                            this.BackgroundImage = global::SmartAssistant.Properties.Resources.beddark;
                        }
                        pictureBox4.Visible = false;
                    }

                    if (room == "kouzina")
                    {
                        if (Program.kitchenlights == true)
                        {
                            this.BackgroundImage = global::SmartAssistant.Properties.Resources.kitchen;
                        }
                        else
                        {
                            this.BackgroundImage = global::SmartAssistant.Properties.Resources.kitchendark;
                        }
                        if (Program.plintPiat == true)
                        {
                            pictureBox5.Visible = true;
                        }
                        else
                        {
                            pictureBox5.Visible = false;
                        }
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox6.Visible = false;
                    }

                    if (room == "saloni")
                    {
                        if (Program.sittinglights == true)
                        {
                            this.BackgroundImage = global::SmartAssistant.Properties.Resources.saloni;
                        }
                        else
                        {
                            this.BackgroundImage = global::SmartAssistant.Properties.Resources.salonidark;
                        }
                        if (Program.radio == true)
                        {
                            pictureBox4.Visible = true;
                        }
                        else
                        {
                            pictureBox4.Visible = false;
                        }
                        if (Program.tv == true)
                        {
                            pictureBox1.Visible = true;
                        }
                        else
                        {
                            pictureBox1.Visible = false;
                        }
                    }

                }
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (Program.sittinglights == true)
            {
                this.BackgroundImage = global::SmartAssistant.Properties.Resources.saloni;
            }
            else
            {
                this.BackgroundImage = global::SmartAssistant.Properties.Resources.salonidark;
            }

            if (Program.foodbowl > 80)
            {
                pictureBox2.Image = global::SmartAssistant.Properties.Resources.fullbowl;
            }
            else if (Program.foodbowl > 30)
            {
                pictureBox2.Image = global::SmartAssistant.Properties.Resources.halfbowl;
            }
            else
            {
                pictureBox2.Image = global::SmartAssistant.Properties.Resources.emptybowl;
            }
            if (Program.waterbowl > 80)
            {
                pictureBox3.Image = global::SmartAssistant.Properties.Resources.waterbowl;
            }
            else if (Program.waterbowl > 30)
            {
                pictureBox3.Image = global::SmartAssistant.Properties.Resources.halfwater;
            }
            else
            {
                pictureBox3.Image = global::SmartAssistant.Properties.Resources.emptybowl;
            }

            if (Program.radio == true)
            {
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox4.Visible = false;
            }
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dEMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void Form8_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");
        }
    }
}
