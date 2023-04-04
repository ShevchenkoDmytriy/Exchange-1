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

namespace Exchange_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            RegistrMenu.Visibility = Visibility.Visible;
            RegisMenu.Visibility = Visibility.Hidden;
        }

        private void logo_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
        }

        private void logo1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Visible;  
        }

        private void logo2_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
        }

        private void logo3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
        }
    }
}
