using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Assignment_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SubmitButton.IsEnabled = false;
        }

        private void Zip_Codes_TextChanged(object sender, EventArgs e)
        {
            var Zip_Entry = Zip_Codes.Text;
            int dashCount = Zip_Codes.Text.Count(t => t == '-');
            int dashlocation = Zip_Codes.Text.IndexOf('-');

            //Check for first format of US Zip Code
            if (Zip_Entry.Length == 5)
            {
                if (Char.IsLetter(Zip_Entry[0]))
                {
                    SubmitButton.IsEnabled = false;
                }
                else
                {
                    SubmitButton.IsEnabled = true;
                }
                
            }

            //Check for Second format of US Zip Code
            else if (Zip_Entry.Length == 10 && dashlocation == 5)
            {
                if (dashCount == 1)
                {
                    SubmitButton.IsEnabled = true;
                }
                else
                {
                    SubmitButton.IsEnabled = false;
                }
            }
            //Check for Third format of Canadian Zip Code
            else if (Zip_Entry.Length == 6)
            {
                if (Char.IsLetter(Zip_Entry[0]) && Char.IsNumber(Zip_Entry[1]) && Char.IsLetter(Zip_Entry[2]) && Char.IsNumber(Zip_Entry[3]) && Char.IsLetter(Zip_Entry[4]) && Char.IsNumber(Zip_Entry[5]))
                {
                    SubmitButton.IsEnabled = true;
                }
                else
                {
                    SubmitButton.IsEnabled = false;
                }
            }
            //Both Formats not found, default to disabled submit button
            else
            {
                SubmitButton.IsEnabled = false;
            }
           
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bada Bing Bada Boom!");
        }
    }
}
