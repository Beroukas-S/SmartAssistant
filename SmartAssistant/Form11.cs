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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    Program.plintRoux = true;
                    break;
                case CheckState.Unchecked:
                    Program.plintRoux = false;
                    break;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox2.CheckState)
            {
                case CheckState.Checked:
                    Program.plintPiat = true;
                    break;
                case CheckState.Unchecked:
                    Program.plintPiat = false;
                    break;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox3.CheckState)
            {
                case CheckState.Checked:
                    Program.klimatismos = true;
                    break;
                case CheckState.Unchecked:
                    Program.klimatismos = false;
                    break;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox4.CheckState)
            {
                case CheckState.Checked:
                    Program.kafstiras = true;
                    break;
                case CheckState.Unchecked:
                    Program.kafstiras = false;
                    break;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox5.CheckState)
            {
                case CheckState.Checked:
                    Program.thermos = true;
                    break;
                case CheckState.Unchecked:
                    Program.thermos = false;
                    break;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox6.CheckState)
            {
                case CheckState.Checked:
                    Program.tv = true;
                    break;
                case CheckState.Unchecked:
                    Program.tv = false;
                    break;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox7.CheckState)
            {
                case CheckState.Checked:
                    Program.radio = true;
                    break;
                case CheckState.Unchecked:
                    Program.radio = false;
                    break;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox8.CheckState)
            {
                case CheckState.Checked:
                    Program.sittinglights = true;
                    break;
                case CheckState.Unchecked:
                    Program.sittinglights = false;
                    break;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox9.CheckState)
            {
                case CheckState.Checked:
                    Program.kitchenlights = true;
                    break;
                case CheckState.Unchecked:
                    Program.kitchenlights = false;
                    break;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox10.CheckState)
            {
                case CheckState.Checked:
                    Program.bedlights = true;
                    break;
                case CheckState.Unchecked:
                    Program.bedlights = false;
                    break;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox11.CheckState)
            {
                case CheckState.Checked:
                    Program.bathlights = true;
                    break;
                case CheckState.Unchecked:
                    Program.bathlights = false;
                    break;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox12.CheckState)
            {
                case CheckState.Checked:
                    Program.casual = true;
                    break;
                case CheckState.Unchecked:
                    Program.casual = false;
                    break;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox13.CheckState)
            {
                case CheckState.Checked:
                    Program.sport = true;
                    break;
                case CheckState.Unchecked:
                    Program.sport = false;
                    break;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox14.CheckState)
            {
                case CheckState.Checked:
                    Program.boots = true;
                    break;
                case CheckState.Unchecked:
                    Program.boots = false;
                    break;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox15.CheckState)
            {
                case CheckState.Checked:
                    Program.formal = true;
                    break;
                case CheckState.Unchecked:
                    Program.formal = false;
                    break;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox16.CheckState)
            {
                case CheckState.Checked:
                    Program.football = true;
                    break;
                case CheckState.Unchecked:
                    Program.football = false;
                    break;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox17.CheckState)
            {
                case CheckState.Checked:
                    Program.basketball = true;
                    break;
                case CheckState.Unchecked:
                    Program.basketball = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            Program.foodbowl = Int32.Parse(value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = textBox2.Text;
            Program.waterbowl = Int32.Parse(value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = textBox3.Text;
            Program.food = Int32.Parse(value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            Program.water = Int32.Parse(value);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox18.CheckState)
            {
                case CheckState.Checked:
                    Program.zimia = true;
                    break;
                case CheckState.Unchecked:
                    Program.zimia = false;
                    break;
            }
        }

        private void Form11_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");
        }
    }
}
