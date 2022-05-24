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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        //Boolean casual = false;
        //Boolean sport = false;
       // Boolean boots = false;
       // Boolean formal = false;
       // Boolean football = false;
       // Boolean basketball = false;
        public Boolean casual { get; set; }
        public Boolean sport { get; set; }
        public Boolean boots { get; set; }
        public Boolean formal { get; set; }
        public Boolean football { get; set; }
        public Boolean basketball { get; set; }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (casual == false)
            {
                label1.ForeColor = Color.Red;
                casual = true;
            }
            else
            {
                label1.ForeColor = Color.Black;
                casual = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (sport == false)
            {
                label2.ForeColor = Color.Red;
                sport = true;
            }
            else
            {
                label2.ForeColor = Color.Black;
                sport = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (boots == false)
            {
                label3.ForeColor = Color.Red;
                boots = true;
            }
            else
            {
                label3.ForeColor = Color.Black;
                boots = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (formal == false)
            {
                label4.ForeColor = Color.Red;
                formal = true;
            }
            else
            {
                label4.ForeColor = Color.Black;
                formal = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (football == false)
            {
                label5.ForeColor = Color.Red;
                football = true;
            }
            else
            {
                label5.ForeColor = Color.Black;
                football = false;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (basketball == false)
            {
                label6.ForeColor = Color.Red;
                basketball = true;
            }
            else
            {
                label6.ForeColor = Color.Black;
                basketball = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.casual = false;
            this.sport = false;
            this.boots = false;
            this.formal = false;
            this.football = false;
            this.basketball = false;
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form9_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");
        }
    }
}
