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
    public partial class Form2 : Form
    {
        int remindCnt =0;
        public Form2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form6 = new Form6())
            {
                Boolean suc = false;
                var result = form6.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string orarantevou = form6.datetime;
                    string diarkeiarantevou = form6.dateduration;
                    string typosrantevou = form6.datetype;
                    string merosrantevou = form6.dateplace;
                    string ipenthimisi = form6.reminder;
                    string metakinisi = form6.metakinisi;
                    string sixnotita = form6.sixnotita;

                    if (orarantevou == "05:00")
                    {
                        if (label23.Text == "")
                        {
                            label23.Text = typosrantevou;
                            label42.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[0, 0] = orarantevou;
                            Program.dayPlan[0, 1] = typosrantevou;
                            Program.dayPlan[0, 2] = ipenthimisi;
                            Program.dayPlan[0, 3] = merosrantevou;
                            Program.dayPlan[0, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "06:00")
                    {
                        if (label24.Text == "")
                        {
                            label24.Text = typosrantevou;
                            label45.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[1, 0] = orarantevou;
                            Program.dayPlan[1, 1] = typosrantevou;
                            Program.dayPlan[1, 2] = ipenthimisi;
                            Program.dayPlan[1, 3] = merosrantevou;
                            Program.dayPlan[1, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "07:00")
                    {
                        if (label25.Text == "")
                        {
                            label25.Text = typosrantevou;
                            label57.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[2, 0] = orarantevou;
                            Program.dayPlan[2, 1] = typosrantevou;
                            Program.dayPlan[2, 2] = ipenthimisi;
                            Program.dayPlan[2, 3] = merosrantevou;
                            Program.dayPlan[2, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "08:00")
                    {
                        if (label26.Text == "")
                        {
                            label26.Text = typosrantevou;
                            label58.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[3, 0] = orarantevou;
                            Program.dayPlan[3, 1] = typosrantevou;
                            Program.dayPlan[3, 2] = ipenthimisi;
                            Program.dayPlan[3, 3] = merosrantevou;
                            Program.dayPlan[3, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                        }
                    else if (orarantevou == "09:00")
                    {

                        if (label27.Text == "")
                        {
                            label27.Text = typosrantevou;
                            label59.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[4, 0] = orarantevou;
                            Program.dayPlan[4, 1] = typosrantevou;
                            Program.dayPlan[4, 2] = ipenthimisi;
                            Program.dayPlan[4, 3] = merosrantevou;
                            Program.dayPlan[4, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "10:00")
                    {
                        if (label28.Text == "")
                        {
                            label28.Text = typosrantevou;
                            label60.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[5, 0] = orarantevou;
                            Program.dayPlan[5, 1] = typosrantevou;
                            Program.dayPlan[5, 2] = ipenthimisi;
                            Program.dayPlan[5, 3] = merosrantevou;
                            Program.dayPlan[5, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "11:00")
                    {
                        if (label29.Text == "")
                        {
                            label29.Text = typosrantevou;
                            label61.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[6, 0] = orarantevou;
                            Program.dayPlan[6, 1] = typosrantevou;
                            Program.dayPlan[6, 2] = ipenthimisi;
                            Program.dayPlan[6, 3] = merosrantevou;
                            Program.dayPlan[6, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "12:00")
                    {
                        if (label30.Text == "")
                        {
                            label30.Text = typosrantevou;
                            label62.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[7, 0] = orarantevou;
                            Program.dayPlan[7, 1] = typosrantevou;
                            Program.dayPlan[7, 2] = ipenthimisi;
                            Program.dayPlan[7, 3] = merosrantevou;
                            Program.dayPlan[7, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "13:00")
                    {
                        if (label31.Text == "")
                        {
                            label31.Text = typosrantevou;
                            label63.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[8, 0] = orarantevou;
                            Program.dayPlan[8, 1] = typosrantevou;
                            Program.dayPlan[8, 2] = ipenthimisi;
                            Program.dayPlan[8, 3] = merosrantevou;
                            Program.dayPlan[8, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "14:00")
                    {
                        if (label32.Text == "")
                        {
                            label32.Text = typosrantevou;
                            label64.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[9, 0] = orarantevou;
                            Program.dayPlan[9, 1] = typosrantevou;
                            Program.dayPlan[9, 2] = ipenthimisi;
                            Program.dayPlan[9, 3] = merosrantevou;
                            Program.dayPlan[9, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "15:00")
                    {
                        if (label33.Text == "")
                        {
                            label33.Text = typosrantevou;
                            label65.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[10, 0] = orarantevou;
                            Program.dayPlan[10, 1] = typosrantevou;
                            Program.dayPlan[10, 2] = ipenthimisi;
                            Program.dayPlan[10, 3] = merosrantevou;
                            Program.dayPlan[10, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "16:00")
                    {
                        if (label34.Text == "")
                        {
                            label34.Text = typosrantevou;
                            label66.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[11, 0] = orarantevou;
                            Program.dayPlan[11, 1] = typosrantevou;
                            Program.dayPlan[11, 2] = ipenthimisi;
                            Program.dayPlan[11, 3] = merosrantevou;
                            Program.dayPlan[11, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "17:00")
                    {
                        if (label35.Text == "")
                        {
                            label35.Text = typosrantevou;
                            label67.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[12, 0] = orarantevou;
                            Program.dayPlan[12, 1] = typosrantevou;
                            Program.dayPlan[12, 2] = ipenthimisi;
                            Program.dayPlan[12, 3] = merosrantevou;
                            Program.dayPlan[12, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "18:00")
                    {
                        if (label36.Text == "")
                        {
                            label36.Text = typosrantevou;
                            label68.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[13, 0] = orarantevou;
                            Program.dayPlan[13, 1] = typosrantevou;
                            Program.dayPlan[13, 2] = ipenthimisi;
                            Program.dayPlan[13, 3] = merosrantevou;
                            Program.dayPlan[13, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "19:00")
                    {
                        if (label37.Text == "")
                        {
                            label37.Text = typosrantevou;
                            label69.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[14, 0] = orarantevou;
                            Program.dayPlan[14, 1] = typosrantevou;
                            Program.dayPlan[14, 2] = ipenthimisi;
                            Program.dayPlan[14, 3] = merosrantevou;
                            Program.dayPlan[14, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "20:00")
                    {
                        if (label38.Text == "")
                        {
                            label38.Text = typosrantevou;
                            label70.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[15, 0] = orarantevou;
                            Program.dayPlan[15, 1] = typosrantevou;
                            Program.dayPlan[15, 2] = ipenthimisi;
                            Program.dayPlan[15, 3] = merosrantevou;
                            Program.dayPlan[15, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "21:00")
                    {
                        if (label39.Text == "")
                        {
                            label39.Text = typosrantevou;
                            label71.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[16, 0] = orarantevou;
                            Program.dayPlan[16, 1] = typosrantevou;
                            Program.dayPlan[16, 2] = ipenthimisi;
                            Program.dayPlan[16, 3] = merosrantevou;
                            Program.dayPlan[16, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "22:00")
                    {
                        if (label40.Text == "")
                        {
                            label40.Text = typosrantevou;
                            label72.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[17, 0] = orarantevou;
                            Program.dayPlan[17, 1] = typosrantevou;
                            Program.dayPlan[17, 2] = ipenthimisi;
                            Program.dayPlan[17, 3] = merosrantevou;
                            Program.dayPlan[17, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "23:00")
                    {
                        if (label41.Text == "")
                        {
                            label41.Text = typosrantevou;
                            label73.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[18, 0] = orarantevou;
                            Program.dayPlan[18, 1] = typosrantevou;
                            Program.dayPlan[18, 2] = ipenthimisi;
                            Program.dayPlan[18, 3] = merosrantevou;
                            Program.dayPlan[18, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    else if (orarantevou == "00:00")
                    {
                        if (label44.Text == "")
                        {
                            label44.Text = typosrantevou;
                            label74.Text = ipenthimisi;
                            suc = true;
                            Program.dayPlan[19, 0] = orarantevou;
                            Program.dayPlan[19, 1] = typosrantevou;
                            Program.dayPlan[19, 2] = ipenthimisi;
                            Program.dayPlan[19, 3] = merosrantevou;
                            Program.dayPlan[19, 4] = sixnotita;
                        }
                        else
                        {
                            MessageBox.Show("Έχετε προγραμματίσει άλλο ραντεβού αυτή την ώρα!", "Πρόβλημα!");
                            MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε.", "Αποτυχία!");
                        }
                    }
                    if (suc == true)
                    {
                        MessageBox.Show("Το πλάνο της ημέρας ενημερώθηκε", "Επιτυχία!");
                    }
                    int dateNum = 0;
                    for (int i = 0; i < 20; i++)
                    {
                        if (Program.dayPlan[i, 1] != "")
                        {
                            dateNum++;
                        }
                    }
                    if (dateNum > 4)
                    {
                        MessageBox.Show("Βλέπω πως θα λείπετε πολλές ώρες, καλό θα ήταν να αφήσετε τροφή για τον σκύλο.","Προσοχή!");
                    }
                }
                else
                {
                    MessageBox.Show("Το πλάνο της ημέρας δεν ενημερώθηκε", "Αποτυχία!");
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label23.Text = Program.dayPlan[0, 1];
            label42.Text = Program.dayPlan[0, 2];
            label24.Text = Program.dayPlan[1, 1];
            label45.Text = Program.dayPlan[1, 2];
            label25.Text = Program.dayPlan[2, 1];
            label57.Text = Program.dayPlan[2, 2];
            label26.Text = Program.dayPlan[3, 1];
            label58.Text = Program.dayPlan[3, 2];
            label27.Text = Program.dayPlan[4, 1];
            label59.Text = Program.dayPlan[4, 2];
            label28.Text = Program.dayPlan[5, 1];
            label60.Text = Program.dayPlan[5, 2];
            label29.Text = Program.dayPlan[6, 1];
            label61.Text = Program.dayPlan[6, 2];
            label30.Text = Program.dayPlan[7, 1];
            label62.Text = Program.dayPlan[7, 2];
            label31.Text = Program.dayPlan[8, 1];
            label63.Text = Program.dayPlan[8, 2];
            label32.Text = Program.dayPlan[9, 1];
            label64.Text = Program.dayPlan[9, 2];
            label33.Text = Program.dayPlan[10, 1];
            label65.Text = Program.dayPlan[10, 2];
            label34.Text = Program.dayPlan[11, 1];
            label66.Text = Program.dayPlan[11, 2];
            label35.Text = Program.dayPlan[12, 1];
            label67.Text = Program.dayPlan[12, 2];
            label36.Text = Program.dayPlan[13, 1];
            label68.Text = Program.dayPlan[13, 2];
            label37.Text = Program.dayPlan[14, 1];
            label69.Text = Program.dayPlan[14, 2];
            label38.Text = Program.dayPlan[15, 1];
            label70.Text = Program.dayPlan[15, 2];
            label39.Text = Program.dayPlan[16, 1];
            label71.Text = Program.dayPlan[16, 2];
            label40.Text = Program.dayPlan[17, 1];
            label72.Text = Program.dayPlan[17, 2];
            label41.Text = Program.dayPlan[18, 1];
            label73.Text = Program.dayPlan[18, 2];
            label44.Text = Program.dayPlan[19, 1];
            label74.Text = Program.dayPlan[19, 2];

            label48.Text = Program.reminders[0];
            label50.Text = Program.reminders[1];
            label52.Text = Program.reminders[2];
            label54.Text = Program.reminders[3];
            label56.Text = Program.reminders[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form7 = new Form7())
            {
                var result = form7.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string newreminder = form7.reminder;
                    if (remindCnt == 0)
                    {
                        label48.Text = newreminder;
                        remindCnt++;
                        Program.reminders[0] = newreminder;
                    }
                    else if (remindCnt == 1)
                    {
                        label50.Text = newreminder;
                        remindCnt++;
                        Program.reminders[1] = newreminder;
                    }
                    else if (remindCnt == 2)
                    {
                        label52.Text = newreminder;
                        remindCnt++;
                        Program.reminders[2] = newreminder;
                    }
                    else if (remindCnt == 3)
                    {
                        label54.Text = newreminder;
                        remindCnt++;
                        Program.reminders[3] = newreminder;
                    }
                    else if (remindCnt == 4)
                    {
                        label56.Text = newreminder;
                        remindCnt++;
                        Program.reminders[4] = newreminder;
                    }
                    else
                    {
                        MessageBox.Show("Πάρα πολλές υπενθυμίσεις", "Αποτυχία!");
                    }


                    MessageBox.Show("Η νέα υπενθύμιση προστέθηκε", "Επιτυχία!");
                }
                else
                {
                    MessageBox.Show("Δεν προστέθηκε η νέα υπενθύμιση", "Αποτυχία!");
                }
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label23.Text != "")
            {
                Program.info = 1;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!","Ειδοποίηση!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (label24.Text != "")
            {
                Program.info = 2;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (label25.Text != "")
            {
                Program.info = 3;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (label26.Text != "")
            {
                Program.info = 4;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (label27.Text != "")
            {
                Program.info = 5;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (label28.Text != "")
            {
                Program.info = 6;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (label29.Text != "")
            {
                Program.info = 7;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (label30.Text != "")
            {
                Program.info = 8;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (label31.Text != "")
            {
                Program.info = 9;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (label32.Text != "")
            {
                Program.info = 10;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (label33.Text != "")
            {
                Program.info = 11;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (label34.Text != "")
            {
                Program.info = 12;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (label35.Text != "")
            {
                Program.info = 13;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (label36.Text != "")
            {
                Program.info = 14;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (label37.Text != "")
            {
                Program.info = 15;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (label38.Text != "")
            {
                Program.info = 16;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (label39.Text != "")
            {
                Program.info = 17;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (label40.Text != "")
            {
                Program.info = 18;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (label41.Text != "")
            {
                Program.info = 19;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (label44.Text != "")
            {
                Program.info = 20;
                var form12 = new Form12();
                var result = form12.ShowDialog();
            }
            else
            {
                MessageBox.Show("Δεν έχετε ραντεβού αυτή την ώρα!", "Ειδοποίηση!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label23.Text = "";
            label42.Text = "";
            {
                //if (Program.dayPlan[0,4] != "καθε μερα")
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[0, j] = "";
                }
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            label24.Text = "";
            label45.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[1, j] = "";
                }
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            label25.Text = "";
            label57.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[2, j] = "";
                }
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            label26.Text = "";
            label58.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[3, j] = "";
                }
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            label27.Text = "";
            label59.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[4, j] = "";
                }
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            label28.Text = "";
            label60.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[5, j] = "";
                }
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            label29.Text = "";
            label61.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[6, j] = "";
                }
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            label30.Text = "";
            label62.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[7, j] = "";
                }
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            label31.Text = "";
            label63.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[8, j] = "";
                }
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            label32.Text = "";
            label64.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[9, j] = "";
                }
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            label33.Text = "";
            label65.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[10, j] = "";
                }
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            label34.Text = "";
            label66.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[11, j] = "";
                }
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            label35.Text = "";
            label67.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[12, j] = "";
                }
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            label36.Text = "";
            label68.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[13, j] = "";
                }
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            label37.Text = "";
            label69.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[14, j] = "";
                }
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            label38.Text = "";
            label70.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[15, j] = "";
                }
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            label39.Text = "";
            label71.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[16, j] = "";
                }
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            label40.Text = "";
            label72.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[17, j] = "";
                }
            }
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            label41.Text = "";
            label73.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[18, j] = "";
                }
            }
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            label44.Text = "";
            label74.Text = "";
            {
                for (int j = 0; j < 5; j++)
                {
                    Program.dayPlan[19, j] = "";
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dEMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void Form2_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ixwpxlf3zqiZcqCXprVrT5Mncrgaarrq/view");
        }
    }
}
