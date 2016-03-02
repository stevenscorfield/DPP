using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        string name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            //the foolowing 2 are only use if you want to separate date within a string output
            int appointmentYear = dateTimePicker1.Value.Year;
            int appointmentDay = dateTimePicker1.Value.Day;
            
            //creates a string output with complete date in uk time
            string appointmentMonth = dateTimePicker1.Value.ToString("dd MMMM yy");

            labelAppointmentMessage.Text = "Thankyou, " + name + ". Your appointment has been booked for " + appointmentDay + " " + appointmentMonth + " " + appointmentYear + ". Please let us know if you can't keep this appointment.";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            name = texBoxName.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
