using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exchange_1
{
    public partial class MainWindow : Window
    {
        int f = 1;
        int def = 0;
        int check = 0;
        public MainWindow()
        {
            InitializeComponent();   

        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            RegistrMenu.Visibility = Visibility.Visible;
            RegisMenu.Visibility = Visibility.Hidden;
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
            }
        }

        private void logo_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
            }
        }

        private void logo1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Visible;
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
            }
        }

        private void logo2_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
            }
        }

        private void logo3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
            }
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
                    def = 1;
                    MessageBox.Show("Реєстрація прошла успішно");
                    MainMenu.Visibility = Visibility.Visible;
                    RegistrMenu.Visibility = Visibility.Hidden;
                    RegisMenu.Visibility = Visibility.Hidden;
                    if (def == 1)
                    {
                        Input.Visibility = Visibility.Hidden;
                        Reg.Visibility = Visibility.Hidden;
                        Money.Visibility = Visibility.Visible;
                    }

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
                        def = 1;
                        MessageBox.Show("Реєстрація прошла успішно");
                        MainMenu.Visibility = Visibility.Visible;
                        RegistrMenu.Visibility = Visibility.Hidden;
                        RegisMenu.Visibility = Visibility.Hidden;
                        if (def == 1)
                        {
                            Input.Visibility = Visibility.Hidden;
                            Reg.Visibility = Visibility.Hidden;
                            Money.Visibility = Visibility.Visible;
                        }
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

        private void Create_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Visible;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                MainWindow window = new MainWindow();
                string log = Convert.ToString(Enter.Text);
                var users = db.Users.ToList();
                foreach (Users u in users)
                {
                    if (u.Gmail == log|| u.Num == log)
                    {
                        MessageBox.Show("Успішно");
                         Next.Visibility = Visibility.Hidden;
                        Next1.Visibility = Visibility.Visible;
                        change.Content = "Пароль";
                        Enter.Clear();
                    }
                }

            }
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
            }
        }

        private void Next1_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                MainWindow window = new MainWindow();
                string log = Convert.ToString(Enter.Text);
                var users = db.Users.ToList();
                foreach (Users u in users)
                {
                    if (u.Password == log)
                    {
                        def = 1;
                        if(def== 1) 
                        {
                            MessageBox.Show("Вхід успішний");
                            RegistrMenu.Visibility = Visibility.Hidden;
                            MainMenu.Visibility = Visibility.Visible;
                        }
                    }
                }

            }
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility  = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
            }
        }   

        private void Lite_Click(object sender, RoutedEventArgs e)
        {
            check = 1;
            if(check==1)
            {
                Lite.Visibility     = Visibility.Hidden;
                Lite1.Visibility = Visibility.Visible;
                Panel.Background = new SolidColorBrush(Color.FromRgb(24, 26, 32));
                Input.Foreground=new SolidColorBrush(Colors.White);
            }
        }

        private void Lite1_Click(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (check == 0)
            {
                Lite.Visibility = Visibility.Visible;
                Lite1.Visibility = Visibility.Hidden;
                Panel.Background = new SolidColorBrush(Colors.White);
                Input.Foreground = new SolidColorBrush(Colors.Black);
                
            }
        }


    }
}
