using System;
using System.Windows;
using TRPO_Lab3.Lib;

namespace TRPO_Lab4.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }


        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txt_Result.Text = Convert.ToString(Math.Round(Channel.Formula(Convert.ToDouble(txt_Radius.Text), Convert.ToDouble(txt_sradius.Text), Convert.ToDouble(txt_height.Text)), 3));
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверно введено число.");
            }      
        }
    }
}
