using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //creating random number class
            Random random = new Random();
            //creating a control function
            foreach (Control control in Controls)
            {
                //all labels will have number written into them
                Label numberLabel = control as Label;
                //test to see if numberLabel entered is correct, otherwise error thrown
                if(numberLabel != null)
                {
                    //creates random number
                    int randomNumber = random.Next(1, 59);
                    numberLabel.Text = randomNumber.ToString();
                }
            }
        }

        //button to close window
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
