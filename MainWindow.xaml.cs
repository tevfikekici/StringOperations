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

namespace StringOperations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        string x = "";
        string a = "Apple,";
        string b = "Banana,";
        string c = "Melon,";
        string d = "Orange,";



        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            x = string.Copy(a); // copy value of a string variable into target string variable
            x = string.Empty; // empty value of a string variable
            string con = string.Concat(a, b, x); // combines multiple string variables

            // checks equality of 2 sthings by consider case sensivity
            if (string.Compare(a, b, StringComparison.CurrentCulture) == 0)
            {
                MessageBox.Show("Equal");
            }
            // checks equality of 2 sthings without considering case sensivity
            else if (string.Compare(a, b, StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                MessageBox.Show("Equal");
            }

        }

        // finds how many words entered to textbox when hit enter button
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)               
            {
                MessageBox.Show("Word count : " + textBox1.Text.Split(' ').Length.ToString());
            }
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            string[] text;
            text = textBox1.Text.Split(' '); // split words by space and add them into a string array

            string words = string.Join(",", text); // combines string values into one string variable with a seperator

        }

        private void button_Substring_Click(object sender, RoutedEventArgs e)
        {
            int position;
            string sentence;
            sentence = textBox2.Text;
            position = (textBox2.Text.IndexOf(".") + 1);

            // gets string value from starging index in given amount of characters
            MessageBox.Show(sentence.Substring(position, sentence.Length - position));


        }

        private void button_Replace_Click(object sender, RoutedEventArgs e)
        {
            // change characters with other
            string a = textBox_Replace_3.Text;
            string b = a.Replace(textBox_Replace_1.Text, textBox_Replace_2.Text);

            textBox_Replace_3.Text = b;
        }

        private void button_Upper_Click(object sender, RoutedEventArgs e)
        {
            textBox_UpperLower.Text = textBox_UpperLower.Text.ToUpper();
        }

        private void button_Lower_Click(object sender, RoutedEventArgs e)
        {
            textBox_UpperLower.Text = textBox_UpperLower.Text.ToLower();
        }

        private void button_StringBuilder_Click(object sender, RoutedEventArgs e)
        {
            W_StringBuilder WB = new W_StringBuilder();
            WB.Show();
        }
    }
}
