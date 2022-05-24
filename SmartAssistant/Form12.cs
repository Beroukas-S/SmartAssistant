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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //ωρα
            if (Program.info == 1)
            {
                label11.Text = Program.dayPlan[0, 0];
            }
            else if (Program.info == 2)
            {
                label11.Text = Program.dayPlan[1, 0];
            }
            else if (Program.info == 3)
            {
                label11.Text = Program.dayPlan[2, 0];
            }
            else if (Program.info == 4)
            {
                label11.Text = Program.dayPlan[3, 0];
            }
            else if (Program.info == 5)
            {
                label11.Text = Program.dayPlan[4, 0];
            }
            else if (Program.info == 6)
            {
                label11.Text = Program.dayPlan[5, 0];
            }
            else if (Program.info == 7)
            {
                label11.Text = Program.dayPlan[6, 0];
            }
            else if (Program.info == 8)
            {
                label11.Text = Program.dayPlan[7, 0];
            }
            else if (Program.info == 9)
            {
                label11.Text = Program.dayPlan[8, 0];
            }
            else if (Program.info == 10)
            {
                label11.Text = Program.dayPlan[9, 0];
            }
            else if (Program.info == 11)
            {
                label11.Text = Program.dayPlan[10, 0];
            }
            else if (Program.info == 12)
            {
                label11.Text = Program.dayPlan[11, 0];
            }
            else if (Program.info == 13)
            {
                label11.Text = Program.dayPlan[12, 0];
            }
            else if (Program.info == 14)
            {
                label11.Text = Program.dayPlan[13, 0];
            }
            else if (Program.info == 15)
            {
                label11.Text = Program.dayPlan[14, 0];
            }
            else if (Program.info == 16)
            {
                label11.Text = Program.dayPlan[15, 0];
            }
            else if (Program.info == 17)
            {
                label11.Text = Program.dayPlan[16, 0];
            }
            else if (Program.info == 18)
            {
                label11.Text = Program.dayPlan[17, 0];
            }
            else if (Program.info == 19)
            {
                label11.Text = Program.dayPlan[18, 0];
            }
            else
            {
                label11.Text = Program.dayPlan[19, 0];
            }

            //ονομα
            if (Program.info == 1)
            {
                label12.Text = Program.dayPlan[0, 1];
            }
            else if (Program.info == 2)
            {
                label12.Text = Program.dayPlan[1, 1];
            }
            else if (Program.info == 3)
            {
                label12.Text = Program.dayPlan[2, 1];
            }
            else if (Program.info == 4)
            {
                label12.Text = Program.dayPlan[3, 1];
            }
            else if (Program.info == 5)
            {
                label12.Text = Program.dayPlan[4, 1];
            }
            else if (Program.info == 6)
            {
                label12.Text = Program.dayPlan[5, 1];
            }
            else if (Program.info == 7)
            {
                label12.Text = Program.dayPlan[6, 1];
            }
            else if (Program.info == 8)
            {
                label12.Text = Program.dayPlan[7, 1];
            }
            else if (Program.info == 9)
            {
                label12.Text = Program.dayPlan[8, 1];
            }
            else if (Program.info == 10)
            {
                label12.Text = Program.dayPlan[9, 1];
            }
            else if (Program.info == 11)
            {
                label12.Text = Program.dayPlan[10, 1];
            }
            else if (Program.info == 12)
            {
                label12.Text = Program.dayPlan[11, 1];
            }
            else if (Program.info == 13)
            {
                label12.Text = Program.dayPlan[12, 1];
            }
            else if (Program.info == 14)
            {
                label12.Text = Program.dayPlan[13, 1];
            }
            else if (Program.info == 15)
            {
                label12.Text = Program.dayPlan[14, 1];
            }
            else if (Program.info == 16)
            {
                label12.Text = Program.dayPlan[15, 1];
            }
            else if (Program.info == 17)
            {
                label12.Text = Program.dayPlan[16, 1];
            }
            else if (Program.info == 18)
            {
                label12.Text = Program.dayPlan[17, 1];
            }
            else if (Program.info == 19)
            {
                label12.Text = Program.dayPlan[18, 1];
            }
            else
            {
                label12.Text = Program.dayPlan[19, 1];
            }

            //place
            if (Program.info == 1)
            {
                label13.Text = Program.dayPlan[0, 3];
            }
            else if (Program.info == 2)
            {
                label13.Text = Program.dayPlan[1, 3];
            }
            else if (Program.info == 3)
            {
                label13.Text = Program.dayPlan[2, 3];
            }
            else if (Program.info == 4)
            {
                label13.Text = Program.dayPlan[3, 3];
            }
            else if (Program.info == 5)
            {
                label13.Text = Program.dayPlan[4, 3];
            }
            else if (Program.info == 6)
            {
                label13.Text = Program.dayPlan[5, 3];
            }
            else if (Program.info == 7)
            {
                label13.Text = Program.dayPlan[6, 3];
            }
            else if (Program.info == 8)
            {
                label13.Text = Program.dayPlan[7, 3];
            }
            else if (Program.info == 9)
            {
                label13.Text = Program.dayPlan[8, 3];
            }
            else if (Program.info == 10)
            {
                label13.Text = Program.dayPlan[9, 3];
            }
            else if (Program.info == 11)
            {
                label13.Text = Program.dayPlan[10, 3];
            }
            else if (Program.info == 12)
            {
                label13.Text = Program.dayPlan[11, 3];
            }
            else if (Program.info == 13)
            {
                label13.Text = Program.dayPlan[12, 3];
            }
            else if (Program.info == 14)
            {
                label13.Text = Program.dayPlan[13, 3];
            }
            else if (Program.info == 15)
            {
                label13.Text = Program.dayPlan[14, 3];
            }
            else if (Program.info == 16)
            {
                label13.Text = Program.dayPlan[15, 3];
            }
            else if (Program.info == 17)
            {
                label13.Text = Program.dayPlan[16, 3];
            }
            else if (Program.info == 18)
            {
                label13.Text = Program.dayPlan[17, 3];
            }
            else if (Program.info == 19)
            {
                label13.Text = Program.dayPlan[18, 3];
            }
            else
            {
                label13.Text = Program.dayPlan[19, 3];
            }

            //remind
            if (Program.info == 1)
            {
                label14.Text = Program.dayPlan[0, 2];
            }
            else if (Program.info == 2)
            {
                label14.Text = Program.dayPlan[1, 2];
            }
            else if (Program.info == 3)
            {
                label14.Text = Program.dayPlan[2, 2];
            }
            else if (Program.info == 4)
            {
                label14.Text = Program.dayPlan[3, 2];
            }
            else if (Program.info == 5)
            {
                label14.Text = Program.dayPlan[4, 2];
            }
            else if (Program.info == 6)
            {
                label14.Text = Program.dayPlan[5, 2];
            }
            else if (Program.info == 7)
            {
                label14.Text = Program.dayPlan[6, 2];
            }
            else if (Program.info == 8)
            {
                label14.Text = Program.dayPlan[7, 2];
            }
            else if (Program.info == 9)
            {
                label14.Text = Program.dayPlan[8, 2];
            }
            else if (Program.info == 10)
            {
                label14.Text = Program.dayPlan[9, 2];
            }
            else if (Program.info == 11)
            {
                label14.Text = Program.dayPlan[10, 2];
            }
            else if (Program.info == 12)
            {
                label14.Text = Program.dayPlan[11, 2];
            }
            else if (Program.info == 13)
            {
                label14.Text = Program.dayPlan[12, 2];
            }
            else if (Program.info == 14)
            {
                label14.Text = Program.dayPlan[13, 2];
            }
            else if (Program.info == 15)
            {
                label14.Text = Program.dayPlan[14, 2];
            }
            else if (Program.info == 16)
            {
                label14.Text = Program.dayPlan[15, 2];
            }
            else if (Program.info == 17)
            {
                label14.Text = Program.dayPlan[16, 2];
            }
            else if (Program.info == 18)
            {
                label14.Text = Program.dayPlan[17, 2];
            }
            else if (Program.info == 19)
            {
                label14.Text = Program.dayPlan[18, 2];
            }
            else
            {
                label14.Text = Program.dayPlan[19, 2];
            }
            Random rand = new Random();
            int roll = rand.Next(1, 4);
            if (roll == 1)
            {
                label15.Text = "Χαμηλή";
                label16.Text = "10 λεπτά";
                label17.Text = "15 λεπτά πριν το ραντεβού";
            }
            else if (roll == 2)
            {
                label15.Text = "Μέτρια";
                label16.Text = "30 λεπτά";
                label17.Text = "35 λεπτά πριν το ραντεβού";
            }
            else
            {
                label15.Text = "Υψηλή";
                label16.Text = "50 λεπτά";
                label17.Text = "55 λεπτά πριν το ραντεβού";
            }

            int kairos = rand.Next(1, 4);
            if (kairos == 1)
            {
                label19.Text = "Ο καιρός προβλέπεται να είναι ζεστός, ντυθείτε κατάλληλα!";
            }
            else if (kairos == 2)
            {
                label19.Text = "Ο καιρός προβλέπεται να είναι κρύος, ντυθείτε κατάλληλα!";
            }
            else
            {
                label19.Text = "Ο καιρός προβλέπεται να είναι βροχερός, πάρτε ομπρέλα!";
            }

            string type = label12.Text;
            if (type.Contains("Πανεπιστήμιο") || type.Contains("πανεπιστήμιο") || type.Contains("Πανεπιστημιο") || type.Contains("πανεπιστημιο"))
            {
                if (kairos == 1 || kairos == 2)
                {
                    label10.Text = "Casual";
                    pictureBox3.Image = global::SmartAssistant.Properties.Resources.casual;
                }
                else
                {
                    label10.Text = "Boots";
                    pictureBox3.Image = global::SmartAssistant.Properties.Resources.boots;
                }
            }
            else if (type.Contains("Γραφείο") || type.Contains("γραφείο") || type.Contains("συνέντευξη") || type.Contains("Συνέντευξη") || type.Contains("Γραφειο") || type.Contains("γραφειο") || type.Contains("συνεντευξη") || type.Contains("Συνεντευξη"))
            {
                label10.Text = "Formal";
                pictureBox3.Image = global::SmartAssistant.Properties.Resources.formal;
            }
            else if (type.Contains("Τρέξιμο") || type.Contains("τρέξιμο") || type.Contains("Τρεξιμο") || type.Contains("τρεξιμο") || type.Contains("Γυμναστήριο") || type.Contains("γυμναστήριο") || type.Contains("Γυμναστηριο") || type.Contains("γυμναστηριο"))
            {
                label10.Text = "Sport";
                pictureBox3.Image = global::SmartAssistant.Properties.Resources.sport;
            }
            else if (type.Contains("Ποδόσφαιρο") || type.Contains("ποδόσφαιρο") || type.Contains("Μπάλα") || type.Contains("μπάλα") || type.Contains("Ποδοσφαιρο") || type.Contains("ποδοσφαιρο") || type.Contains("Μπαλα") || type.Contains("μπαλα"))
            {
                label10.Text = "Ποδοσφαιρικά";
                pictureBox3.Image = global::SmartAssistant.Properties.Resources.football;
            }
            else if (type.Contains("Μπάσκετ") || type.Contains("μπάσκετ") || type.Contains("Μπασκετ") || type.Contains("μπασκετ"))
            {
                label10.Text = "Μπασκετικά";
                pictureBox3.Image = global::SmartAssistant.Properties.Resources.basket;
            }
            else
            {
                label10.Text = "Casual";
                pictureBox3.Image = global::SmartAssistant.Properties.Resources.casual;
                label7.Visible = true;
                button3.Visible = true;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Εικονικές οδηγίες διαδρομής.", "Οδηγίες");
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            button2.Visible = true;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.BackColor = Color.FromKnownColor(KnownColor.GradientActiveCaption);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            button2.Visible = false;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tableLayoutPanel2.BackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Εικονικό e-shop.","Ειδοποίηση.");
        }

        private void Form12_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");
        }
    }
}
