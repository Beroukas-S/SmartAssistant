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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

        }

        public string datetime { get; set; }
        public string dateduration { get; set; }
        public string datetype { get; set; }
        public string dateplace { get; set; }
        public string reminder { get; set; }
        public string metakinisi { get; set; }
        public string sixnotita { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
            textBox3.BackColor = Color.White;;
            checkedListBox1.BackColor = Color.White;

            if (comboBox1.SelectedIndex > -1 && textBox3.Text != "" && checkedListBox1.CheckedItems.Count != 0)
            {
                this.datetime = comboBox1.SelectedItem.ToString();
                //this.dateduration = textBox2.Text;
                this.datetype = textBox3.Text;
                this.dateplace = textBox4.Text;
                this.reminder = textBox5.Text;

                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                    {
                        this.sixnotita = checkedListBox1.CheckedItems[x].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Επιλέξτε συχνότητα!", "Πρόβλημα!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (comboBox1.SelectedIndex < 0)
                {
                    comboBox1.BackColor = Color.Red;
                }
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = Color.Red;
                }
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    checkedListBox1.BackColor = Color.Red;
                }
                MessageBox.Show("Συμπληρώστε τα κόκκινα πεδία!", "Πρόβλημα!");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            for (int x=0; x<count; x++)
            {
                if (index != x)
                {
                    checkedListBox1.SetItemChecked(x, false);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form6_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");

        }
    }
}
