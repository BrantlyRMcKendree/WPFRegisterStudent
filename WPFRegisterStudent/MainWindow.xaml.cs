using System;
using System.CodeDom;
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
using System.Xml.Serialization;

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;


        public MainWindow()
        {
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "";

            

        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem); // Creates a selected item to be tested and validated.
            

            if (choice.IsRegisteredAlready() == true) //Checks if the class has been registered for.
            {   
                this.label3.Content = ($"You have already registered for {choice}."); // Displays message in error box.
            }
            

            else if (Course.creditHours >= 9) // Credit hour validation
            {
                this.label3.Content = ("You can not register for more than 9 credit hours."); // Displays message in error box.
            }

            else
            {
                choice.SetToRegistered(); // Sets the course to IsRegisteredAlready = true and adds 3 hours to credit hours.
                this.listBox.Items.Add(choice); // Adds choice to list box.
                this.label3.Content = ($"Registration confirmed for course {choice}."); // Displays message confirming registration.
                this.textBox.Text = Convert.ToString(Course.creditHours); // Converts the creditHours to a string to be input into textbox.

            }
        

        }

        private void button_Click_Remove(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem); // Creates a selected item to be tested and validated.

            if (choice.IsRegisteredAlready() == true)
            {
                this.listBox.Items.Remove(choice);
                choice.RemovedFromRegistered();
                this.textBox.Text = Convert.ToString(Course.creditHours);
            }
            else
            {
                this.label3.Content = ($"{choice} isn't registered.");
            }
        }
    }

}