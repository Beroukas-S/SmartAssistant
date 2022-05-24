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
    public partial class Form4 : Form
    {
        public Form4()
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
            
        }

        private void παπουτσοθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            progressBar1.Value = Program.foodbowl;
            progressBar2.Value = Program.waterbowl;
            label6.Text = Program.food + " Μερίδες";
            label7.Text = Program.water + " Μερίδες";
            if (Program.food == 0)
            {
                label5.Visible = false;
                label8.Visible = true;
                button3.Visible = true;
            }
            if (Program.water == 0)
            {
                label9.Visible = true;
            }
            if (Program.food == 0 && Program.water == 0)
            {
                label5.Visible = false;
            }
            if (Program.zimia == true)
            {
                MessageBox.Show("Ο φίλος σας έκανε μια μικρή ζημειά όσο λείπατε!","Ειδοποίηση!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.foodbowl == 100)
            {
                MessageBox.Show("Το μπολ είναι ήδη γεμάτο!", "Ειδοποίηση!");
            }
            else if (Program.food==0)
            {
                MessageBox.Show("Η τροφή έχει τελειώσει!", "Ειδοποίηση"); 
            }
            else
            {
                Program.foodbowl = 100;
                progressBar1.Value = Program.foodbowl;
                Program.food = Program.food - 1;
                label6.Text = Program.food + " Μερίδες";
            }
            if (Program.food == 0)
            {
                label8.Visible = true;
                button3.Visible = true;
            }
            if (Program.food == 0 && Program.water == 0)
            {
                label5.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.waterbowl == 100)
            {
                MessageBox.Show("Το μπολ είναι ήδη γεμάτο!", "Ειδοποίηση!");
            }
            else if (Program.water == 0)
            {
                MessageBox.Show("Το νερό έχει τελειώσει!", "Ειδοποίηση");
            }
            else
            {
                Program.waterbowl = 100;
                progressBar2.Value = Program.waterbowl;
                Program.water = Program.water - 1;
                label7.Text = Program.water + " Μερίδες";
            }
            if (Program.water == 0)
            {
                label9.Visible = true;
            }
            if (Program.food == 0 && Program.water == 0)
            {
                label5.Visible = false;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dEMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void Form4_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Εικονική αγορά.","Ειδοποίηση!");
        }
    }
}
