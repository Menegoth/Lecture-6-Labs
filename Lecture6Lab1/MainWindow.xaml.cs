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

/// Week 6		Lab 1
/// File Name: MainWindow.xaml.cs
/// @author: Antonio Monteiro
/// Date:  October 5th 2020

namespace Lecture6Lab1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e) {

            //catch errors
            try {
                //assign values from window
                int operation = operationList.SelectedIndex;
                decimal leftHand = Convert.ToDecimal(leftTextBox.Text);
                decimal rightHand = Convert.ToDecimal(rightTextBox.Text);
                decimal result = 0;

                //perform operations based on operator
                switch(operation) {

                    case 0: //case +
                        result = leftHand + rightHand;
                        resultsLabel.Content = result;
                        break;

                    case 1: //case -
                        result = leftHand - rightHand;
                        resultsLabel.Content = result;
                        break;

                    case 2: //case *
                        result = leftHand * rightHand;
                        resultsLabel.Content = result;
                        break;

                    case 3: //case /
                        result = leftHand / rightHand;
                        resultsLabel.Content = result;
                        break;

                    case 4: //case %
                        result = leftHand % rightHand;
                        resultsLabel.Content = result;
                        break;

                    default: //no operator selected
                        result = 0;
                        MessageBox.Show("No operation selected.");
                        break;

                }

            }
            catch (DivideByZeroException error) {
                MessageBox.Show("ERROR: " + error.Message);
            }
            catch (FormatException error) {
                MessageBox.Show("ERROR: " + error.Message);
            }
            catch (OverflowException error) {
                MessageBox.Show("ERROR: " + error.Message);
            }

        }
    }
}
