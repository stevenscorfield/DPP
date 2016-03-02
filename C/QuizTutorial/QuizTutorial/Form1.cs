using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTutorial
{
    public partial class Form1 : Form
    {
        int timeLeft = 60;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("You got all the questions right.", "Well done!");
            }

            else if (timeLeft > 0)
            {
                //update & display time left
                timeLeft--;
                label3.Text = timeLeft + " seconds";
            }

            else
            {
                //if user runs out of time
                timer1.Stop();
                label3.Text = "Time's up!";
                MessageBox.Show("You ran out of time!");
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioFish1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFish1.Checked)
            {
                fishOutcome.ForeColor = Color.Red;
                fishOutcome.Text = "\u00fb"; //cross
                q1Correct = false;
            }
            else
            {
                fishOutcome.Text = "";
            }

        }

        private void radioFish2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFish2.Checked)
            {
                fishOutcome.ForeColor = Color.Green;
                fishOutcome.Text = "\u00fc"; //tick
                q1Correct = true;
            }
            else
            {
                fishOutcome.Text = "";
            }
        }

        private void radioFish3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFish3.Checked)
            {
                fishOutcome.ForeColor = Color.Red;
                fishOutcome.Text = "\u00fb"; //cross
                q1Correct = false;
            }
            else
            {
                fishOutcome.Text = "";
            }
        }

        private void radioAnimal1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAnimal1.Checked)
            {
                anOutcome.ForeColor = Color.Red;
                anOutcome.Text = "\u00fb"; //cross
                q2Correct = false;
            }
            else
            {
                anOutcome.Text = "";
            }
        }

        private void radioAnimal2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAnimal2.Checked)
            {
                anOutcome.ForeColor = Color.Red;
                anOutcome.Text = "\u00fb"; //cross
                q2Correct = false;
            }
            else
            {
                fishOutcome.Text = "";
            }
        }

        private void radioAnimal3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAnimal3.Checked)
            {
                anOutcome.ForeColor = Color.Green;
                anOutcome.Text = "\u00fc"; //tick
                q2Correct = true;
            }
            else
            {
                anOutcome.Text = "";
            }
        }

        private void radioWhere1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAnimal3.Checked)
            {
                anOutcome.ForeColor = Color.Green;
                anOutcome.Text = "\u00fc"; //tick
                q3Correct = true;
            }
            else
            {
                anOutcome.Text = "";
            }
        }

        private void radioWhere2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWhere2.Checked)
            {
                whereOutcome.ForeColor = Color.Red;
                fishOutcome.Text = "\u00fb"; //cross
                q3Correct = false;
            }
            else
            {
                whereOutcome.Text = "";
            }
        }

        private void radioWhere3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWhere3.Checked)
            {
                whereOutcome.ForeColor = Color.Red;
                whereOutcome.Text = "\u00fb"; //cross
                q3Correct = false;
            }
            else
            {
                whereOutcome.Text = "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
