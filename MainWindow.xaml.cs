using System;
using System.Collections;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();    
        }

        private void Value_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Key_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(key.Text, value.Text);
            key.Text = "";
            value.Text = "";
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(key.Text);
            key.Text = "";
            value.Text = "";
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            ICollection collection = hashtable.Keys;
            foreach (string key in collection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
