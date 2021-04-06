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
using System.Windows.Shapes;

namespace StringOperations
{
    /// <summary>
    /// Interaction logic for W_StringBuilder.xaml
    /// </summary>
    public partial class W_StringBuilder : Window
    {
        public W_StringBuilder()
        {
            InitializeComponent();
            this.Loaded += W_StringBuilder_Loaded;
        }
        
        StringBuilder dt = new StringBuilder();

        private void W_StringBuilder_Loaded(object sender, RoutedEventArgs e)
        {
            string text = "First text";
            StringBuilder sb = new StringBuilder(text);

            sb.AppendLine("Second text"); // add string as a pharagraph
            sb.Append("Third text"); // add string

            MessageBox.Show(sb.ToString());





           
            dt.AppendFormat("{0:hh:mm:ss}", DateTime.Now);
            dt.AppendLine();
            dt.AppendFormat("{0:HH:mm:ss}", DateTime.Now);
            dt.AppendLine();
            dt.AppendFormat("{0:hh:MM:ss}", DateTime.Now);
            dt.AppendLine();
            dt.AppendFormat("{0:hh:MMMM:ss}", DateTime.Now);
            dt.AppendLine();
            dt.AppendFormat("{0:hh:mm:ss dd MMMM yyyy}", DateTime.Now);
            dt.AppendLine();

            dt.Insert(8, "\n" + "Inserted text", 5); // insert string starting from given index in given amount

            dt.Remove(9, 2); // remove string starting from given index in given amount

            textBox1.AppendText(dt.ToString());

        }

        private void buttonReplace_Click(object sender, RoutedEventArgs e)
        {
            dt.Replace(textBox1.Text, "Replaced text"); // replace string (old value, new value)
            textBox1.Text = dt.ToString();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            dt.Clear();
            textBox1.Text = dt.ToString();
        }
    }
}
