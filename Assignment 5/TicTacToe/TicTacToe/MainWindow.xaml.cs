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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxTurn.Text = "Turn: " + 0;
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button ctrl in uxGrid.Children)
            {
                ctrl.IsEnabled = true;
                ctrl.Content = null;
            }
            uxTurn.Text = "Turn: " + 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Get Counter from Status Bar
            string counter = uxTurn.Text.ToString();
            var counter_int = counter[counter.Length - 1];

            //Determine values of button clicked
            Button values = sender as Button;
            var tag_values = values.Tag.ToString();



            var row = tag_values[0];
            var column = tag_values[2];

            //Determine whether X or O
            if (counter_int % 2 == 0)
            {
                //number is odd, place an x
                //Console.WriteLine("Number is even");
                counter_int++;
                values.Content = "X";
                uxTurn.Text = "Turn: " + counter_int;
                values.IsEnabled = false;
            }
            else
            {
                //number is even, place an o
                //Console.WriteLine("Number is odd");
                counter_int++;
                values.Content = "O";
                uxTurn.Text = "Turn: " + counter_int;
                values.IsEnabled = false;
            }

            //Enter Code to Check for Winner - Horizontal
            bool winner = false;

            int counter_results = 0;
            string[] results = new string[9];

            foreach (Button ctrl in uxGrid.Children)
            {
                if (ctrl.Content != null)
                {
                    results[counter_results] = ctrl.Content.ToString();
                }
                else { }
                counter_results++;

                //Figure out how to target each button content
                if (results[0] == results[1] && results[1] == results[2] && results[2] != null) { winner = true; uxTurn.Text = results[2] + " is the Winner!"; }
                if (results[3] == results[4] && results[4] == results[5] && results[5] != null) { winner = true; uxTurn.Text = results[5] + " is the Winner!"; }
                if (results[6] == results[7] && results[7] == results[8] && results[8] != null) { winner = true; uxTurn.Text = results[8] + " is the Winner!"; }

                if (results[0] == results[3] && results[3] == results[6] && results[6] != null) { winner = true; uxTurn.Text = results[6] + " is the Winner!"; }
                if (results[1] == results[4] && results[4] == results[7] && results[7] != null) { winner = true; uxTurn.Text = results[7] + " is the Winner!"; }
                if (results[2] == results[5] && results[8] == results[5] && results[8] != null) { winner = true; uxTurn.Text = results[8] + " is the Winner!"; }

                if (results[0] == results[4] && results[4] == results[8] && results[8] != null) { winner = true; uxTurn.Text = results[8] + " is the Winner!"; }
                if (results[2] == results[4] && results[4] == results[6] && results[6] != null) { winner = true; uxTurn.Text = results[6] + " is the Winner!"; }

                if (winner == true)
                {
                    foreach (Button ctrl1 in uxGrid.Children)
                    {
                        ctrl1.IsEnabled = false;
                    }
                }
            }

        }

        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
