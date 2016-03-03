using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            CreatePerson();
        }


        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Person thisPerson = this.DataContext as Person;
            textBlock.Text = "Your name is " + thisPerson.Name + " and your phone number is " + thisPerson.PhoneNumber;
        }

        private void CreatePerson()
        {
            Person person1 = new Person();
            person1.Name = "";
            person1.PhoneNumber = "";

            this.DataContext = person1;
        }
    }
    public class Person
    {
        public string Name;
        public string PhoneNumber;
    }
}

