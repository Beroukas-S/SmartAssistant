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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void έλεγχοςΣπιτιούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();
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
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Program.casual == true)
            {
                pictureBox3.Visible = true;
                label1.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
                label1.Visible = false;
            }
            if (Program.sport == true)
            {
                pictureBox4.Visible = true;
                label2.Visible = true;
            }
            else
            {
                pictureBox4.Visible = false;
                label2.Visible = false;
            }
            if (Program.boots == true)
            {
                pictureBox5.Visible = true;
                label3.Visible = true;
            }
            else
            {
                pictureBox5.Visible = false;
                label3.Visible = false;
            }
            if (Program.formal == true)
            {
                pictureBox6.Visible = true;
                label4.Visible = true;
            }
            else
            {
                pictureBox6.Visible = false;
                label4.Visible = false;
            }
            if (Program.football == true)
            {
                pictureBox7.Visible = true;
                label5.Visible = true;
            }
            else
            {
                pictureBox7.Visible = false;
                label5.Visible = false;
            }
            if (Program.basketball == true)
            {
                pictureBox8.Visible = true;
                label6.Visible = true;
            }
            else
            {
                pictureBox8.Visible = false;
                label6.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form9 = new Form9())
            {
                var result = form9.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Boolean delcasual = form9.casual;
                    Boolean delsport = form9.sport;
                    Boolean delboots = form9.boots;
                    Boolean delformal = form9.formal;
                    Boolean delfootball = form9.football;
                    Boolean delbasketball = form9.basketball;
                    if (delcasual == true)
                    {
                        pictureBox3.Visible = false;
                        label1.Visible = false;
                        Program.casual = false;
                    }
                    if (delsport == true)
                    {
                        pictureBox4.Visible = false;
                        label2.Visible = false;
                        Program.sport = false;
                    }
                    if (delboots == true)
                    {
                        pictureBox5.Visible = false;
                        label3.Visible = false;
                        Program.boots = false;
                    }
                    if (delformal == true)
                    {
                        pictureBox6.Visible = false;
                        label4.Visible = false;
                        Program.formal = false;
                    }
                    if (delfootball == true)
                    {
                        pictureBox7.Visible = false;
                        label5.Visible = false;
                        Program.football = false;
                    }
                    if (delbasketball == true)
                    {
                        pictureBox8.Visible = false;
                        label6.Visible = false;
                        Program.basketball = false;
                    }
                    MessageBox.Show("Η παπουτσοθήκη ανανεώθηκε!", "Επιτυχία!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form10 = new Form10())
            {
                var result = form10.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Boolean addcasual = form10.casual;
                    Boolean addsport = form10.sport;
                    Boolean addboots = form10.boots;
                    Boolean addformal = form10.formal;
                    Boolean addfootball = form10.football;
                    Boolean addbasketball = form10.basketball;
                    if (addcasual == true)
                    {
                        pictureBox3.Visible = true;
                        label1.Visible = true;
                        Program.casual = true;
                    }
                    if (addsport == true)
                    {
                        pictureBox4.Visible = true;
                        label2.Visible = true;
                        Program.sport = true;
                    }
                    if (addboots == true)
                    {
                        pictureBox5.Visible = true;
                        label3.Visible = true;
                        Program.boots = true;
                    }
                    if (addformal == true)
                    {
                        pictureBox6.Visible = true;
                        label4.Visible = true;
                        Program.formal = true;
                    }
                    if (addfootball == true)
                    {
                        pictureBox7.Visible = true;
                        label5.Visible = true;
                        Program.football = true;
                    }
                    if (addbasketball == true)
                    {
                        pictureBox8.Visible = true;
                        label6.Visible = true;
                        Program.basketball = true;
                    }
                    MessageBox.Show("Η παπουτσοθήκη ανανεώθηκε!", "Επιτυχία!");
                }
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dEMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void Form5_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");
        }
    }
}
