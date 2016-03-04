using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioloadCalculator
{
    public partial class Form1 : Form
    {
        //Declares volume as a double and index as an int
        double volume = 0;
        
        //Counter so that we can calculate how many fish in tank allowed
           
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        //private void buttonLitres_Click(object sender, EventArgs e)
        //{
        //    
        //}

        //private void buttonGallons_Click(object sender, EventArgs e)
       // {
            //if (gallons < 10)
           // {
                
           // }
       // }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            volume = Double.Parse(textVolume.Text);
            //declares ratio between water volume and fish size
            double volumeResult = (volume * 0.2) / 1.5;
            volumeResult = Math.Round(volumeResult, 0);

            //prevents a person from seeing how many fish they can have if tank is too small
            if (volume < 10)
            {
                labelOutput.Text = "You're tank is too small to have marine fish!" + volume;
            }

            //publishes the biload in percentage, along with amount of fish
            else
            {
                if (volume > 1000)
                {
                    labelOutput.Text = "The amount of fish you can have is " + volumeResult + ". Is this Poseidon? If so you don't have to worry about fish stock in the oceans!";
                }

                else
                {
                    labelOutput.Text = "The amount of fish you can have is " + volumeResult + ".";
                }
            }
        }


        private void buttonClearAll_Click(object sender, EventArgs e)
        {

        }

        //closes the calculator
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //converts user input into a double
        private void textVolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioGallons_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioLitres_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
