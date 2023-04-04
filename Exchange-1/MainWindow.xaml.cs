using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
        int f = 1;
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

        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Visible;
        }

        private void CreateAcc_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if(f==1)
                {
                    string mail = Convert.ToString(RegInput1.Text);
                    string pas = Convert.ToString(RegInput2.Text);
                    Users peop = new Users { Gmail = mail, Password = pas };
                    var users = db.Users.ToList();
                    db.Users.Add(peop);
                    db.SaveChanges();
                    MessageBox.Show("Реєстрація прошла успішно");
                }
                if (f == 2)
                {
                    int mail = Convert.ToInt32(RegInput3.Text);
                    string pas = Convert.ToString(RegInput2.Text);
                    if(mail>=100000000&mail<=999999999)
                    {
                        Users peop = new Users { Num = $"+380{mail}", Password = pas };
                        var users = db.Users.ToList();
                        db.Users.Add(peop);
                        db.SaveChanges();
                        MessageBox.Show("Реєстрація прошла успішно");
                    }
                    else
                    {
                        MessageBox.Show("Помилка");
                    }
                }

            }
        }

        private void email_Click(object sender, RoutedEventArgs e)
        {
            f = 1;
            email.Foreground=new SolidColorBrush(Colors.Black);
            num.Foreground = new SolidColorBrush(Colors.Gray);
            swap.Content = "Персональна ел. пошта";
            num1.Visibility = Visibility.Hidden;
            RegInput3.Visibility = Visibility.Hidden;
            RegInput1.Visibility = Visibility.Visible;
        }
        private void num_Click(object sender, RoutedEventArgs e)
        {
            f = 2;
            email.Foreground = new SolidColorBrush(Colors.Gray);
            num.Foreground = new SolidColorBrush(Colors.Black);
            swap.Content = "Персональний номер телефону";
            num1.Visibility=Visibility.Visible;
            RegInput3.Visibility = Visibility.Visible;
            RegInput1.Visibility = Visibility.Hidden;
        }
    }
}
