using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Runner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SequenceAnalysis_Click(object sender, RoutedEventArgs e)
        {
            StringOutput.Text =
                SequenceAnalysis.SequenceAnalysis.OrderAlphabetically(StringInput.Text.Trim());
        }

        private void SumOfMultiples_Click(object sender, RoutedEventArgs e)
        {
            StringOutput.Text =
                SumOfMultiplesLibrary.SumOfMultiples.CalculateMultiples(Convert.ToInt32(InputValue.Text)).ToString();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
