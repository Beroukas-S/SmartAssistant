﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();
            //this.Hide();
            //form3.Show();
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

        private void έλεγχοςΣπιτιούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();

            /*

            using (var form3 = new Form3())
            {
                var result = form3.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }

            */

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dEMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");

        }
    }
}
