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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton1.CheckState)
            {
                case CheckState.Checked:
                    Program.plintRoux = true;
                    break;
                case CheckState.Unchecked:
                    Program.plintRoux = false;
                    break;
            }
        }

        private void toggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton2.CheckState)
            {
                case CheckState.Checked:
                    Program.plintPiat = true;
                    break;
                case CheckState.Unchecked:
                    Program.plintPiat = false;
                    break;
            }
        }

        private void toggleButton3_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton3.CheckState)
            {
                case CheckState.Checked:
                    Program.klimatismos = true;
                    break;
                case CheckState.Unchecked:
                    Program.klimatismos = false;
                    break;
            }
        }

        private void toggleButton4_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton4.CheckState)
            {
                case CheckState.Checked:
                    Program.kafstiras = true;
                    break;
                case CheckState.Unchecked:
                    Program.kafstiras = false;
                    break;
            }
        }

        private void toggleButton5_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton5.CheckState)
            {
                case CheckState.Checked:
                    Program.thermos = true;
                    break;
                case CheckState.Unchecked:
                    Program.thermos = false;
                    break;
            }
        }

        private void toggleButton6_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton6.CheckState)
            {
                case CheckState.Checked:
                    Program.tv = true;
                    break;
                case CheckState.Unchecked:
                    Program.tv = false;
                    break;
            }
        }

        private void toggleButton7_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton7.CheckState)
            {
                case CheckState.Checked:
                    Program.radio = true;
                    break;
                case CheckState.Unchecked:
                    Program.radio = false;
                    break;
            }
        }

        private void toggleButton8_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton8.CheckState)
            {
                case CheckState.Checked:
                    Program.sittinglights = true;
                    break;
                case CheckState.Unchecked:
                    Program.sittinglights = false;
                    break;
            }
        }

        private void toggleButton9_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton9.CheckState)
            {
                case CheckState.Checked:
                    Program.kitchenlights = true;
                    break;
                case CheckState.Unchecked:
                    Program.kitchenlights = false;
                    break;
            }
        }

        private void toggleButton10_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton10.CheckState)
            {
                case CheckState.Checked:
                    Program.bedlights = true;
                    break;
                case CheckState.Unchecked:
                    Program.bedlights = false;
                    break;
            }
        }

        private void toggleButton11_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleButton11.CheckState)
            {
                case CheckState.Checked:
                    Program.bathlights = true;
                    break;
                case CheckState.Unchecked:
                    Program.bathlights = false;
                    break;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Program.plintRoux == true)
            {
                toggleButton1.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton1.CheckState = CheckState.Unchecked;
            }
            if (Program.plintPiat == true)
            {
                toggleButton2.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton2.CheckState = CheckState.Unchecked;
            }
            if (Program.klimatismos == true)
            {
                toggleButton3.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton3.CheckState = CheckState.Unchecked;
            }
            if (Program.kafstiras == true)
            {
                toggleButton4.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton4.CheckState = CheckState.Unchecked;
            }
            if (Program.thermos == true)
            {
                toggleButton5.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton5.CheckState = CheckState.Unchecked;
            }
            if (Program.tv == true)
            {
                toggleButton6.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton6.CheckState = CheckState.Unchecked;
            }
            if (Program.radio == true)
            {
                toggleButton7.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton7.CheckState = CheckState.Unchecked;
            }
            if (Program.sittinglights == true)
            {
                toggleButton8.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton8.CheckState = CheckState.Unchecked;
            }
            if (Program.kitchenlights == true)
            {
                toggleButton9.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton9.CheckState = CheckState.Unchecked;
            }
            if (Program.bedlights == true)
            {
                toggleButton10.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton10.CheckState = CheckState.Unchecked;
            }
            if (Program.bathlights == true)
            {
                toggleButton11.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButton11.CheckState = CheckState.Unchecked;
            }
        }

        private void Form3_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");
        }
    }
}
