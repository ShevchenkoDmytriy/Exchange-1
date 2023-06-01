using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        int f1 = 0;
        int id = 0;
        string connect = @"Data Source = HOME-PC; Initial Catalog = Exchange; Trusted_Connection=True";
        string sqlExpression = "SELECT * FROM Registr";
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
            Cost.Visibility = Visibility.Hidden;
            pay1.Visibility = Visibility.Hidden;
            pov.Visibility = Visibility.Hidden;
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
            Cost.Visibility = Visibility.Hidden;
            pay1.Visibility = Visibility.Hidden;
            pov.Visibility = Visibility.Hidden;
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

            if (f == 1)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                object nik = reader.GetValue(1);
                                if (RegInput1.Text.ToLower() == nik.ToString().ToLower())
                                {
                                    MessageBox.Show("Ця пошта вже зареєстрована.");
                                    return;
                                }
                            }
                            reader.Close();
                        }

                        Registration();
                        reader.Close();

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }

            }
            if (f == 2)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                object nik = reader.GetValue(2);
                                if (RegInput3.Text.ToLower() == nik.ToString().ToLower())
                                {
                                    MessageBox.Show("Цей номер телефону вже зареєстрований.");
                                    return;
                                }
                            }
                            reader.Close();
                        }

                        Registration();
                        reader.Close();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
            }

        }

        private void email_Click(object sender, RoutedEventArgs e)
        {
            f = 1;
            email.Foreground = new SolidColorBrush(Colors.Black);
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
            num1.Visibility = Visibility.Visible;
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
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        object nik = reader.GetValue(1);
                        object nik1 = reader.GetValue(2);
                        if (Enter.Text.ToLower() == nik.ToString().ToLower())
                        {
                            Next.Visibility = Visibility.Hidden;
                            Next1.Visibility = Visibility.Visible;
                            change.Content = "Пароль";
                            Enter.Clear();
                            Email.Text = nik.ToString();
                            Number.Text = nik1.ToString();
                        }
                        if (Enter.Text.ToLower() == nik1.ToString().ToLower())
                        {
                            Next.Visibility = Visibility.Hidden;
                            Next1.Visibility = Visibility.Visible;
                            change.Content = "Пароль";
                            Enter.Clear();
                            Email.Text = nik.ToString();
                            Number.Text = nik1.ToString();
                        }
                    }
                    reader.Close();
                }
            }
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
                but1.Visibility = Visibility.Hidden;
                Input1.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
                but1.Visibility = Visibility.Visible;
                Input1.Visibility = Visibility.Hidden;
            }
        }

        private void Next1_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        object pas = reader.GetValue(3);
                        if (Enter.Text.ToLower() == pas.ToString().ToLower())
                        {
                            object nik = reader.GetValue(1);
                            object nik1 = reader.GetValue(2);
                            def = 1;
                            if (def == 1)
                            {
                                RegistrMenu.Visibility = Visibility.Hidden;
                                MainMenu.Visibility = Visibility.Visible;
                                but1.Visibility = Visibility.Hidden;
                                Input1.Visibility = Visibility.Visible;
                            }
                        }
                    }
                    reader.Close();
                }
            }
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
                but1.Visibility = Visibility.Hidden;
                Input1.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
                but1.Visibility = Visibility.Visible;
                Input1.Visibility = Visibility.Hidden;
            }
        }

        private void Lite_Click(object sender, RoutedEventArgs e)
        {
            check = 1;
            if (check == 1)
            {
                Lite.Visibility = Visibility.Hidden;
                Lite1.Visibility = Visibility.Visible;
                Panel.Background = new SolidColorBrush(Color.FromRgb(24, 26, 32));
                Input.Foreground = new SolidColorBrush(Colors.White);
                Main1.Foreground = new SolidColorBrush(Colors.White);
                Main2.Foreground = new SolidColorBrush(Colors.White);
                Main3.Foreground = new SolidColorBrush(Colors.White);
                Main4.Foreground = new SolidColorBrush(Colors.White);
                Main5.Foreground = new SolidColorBrush(Colors.White);
                Main6.Foreground = new SolidColorBrush(Colors.White);
                Main7.Foreground = new SolidColorBrush(Colors.White);
                Main8.Foreground = new SolidColorBrush(Colors.White);
                Main10.Foreground = new SolidColorBrush(Colors.White);
                Main11.Foreground = new SolidColorBrush(Colors.White);
                Main12.Foreground = new SolidColorBrush(Colors.White);
                Main13.Foreground = new SolidColorBrush(Colors.White);
                Main14.Foreground = new SolidColorBrush(Colors.White);
                Main15.Foreground = new SolidColorBrush(Colors.White);
                stack1.Background = new SolidColorBrush(Color.FromRgb(11, 14, 17));
                stack2.Background = new SolidColorBrush(Color.FromRgb(24, 26, 32));
                stack3.Background = new SolidColorBrush(Color.FromRgb(24, 26, 32));
                stack4.Background = new SolidColorBrush(Color.FromRgb(24, 26, 32));
                stack5.Background = new SolidColorBrush(Color.FromRgb(11, 14, 17));
                stack6.Background = new SolidColorBrush(Color.FromRgb(11, 14, 17));
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
                Main1.Foreground = new SolidColorBrush(Colors.Black);
                Main2.Foreground = new SolidColorBrush(Colors.Black);
                Main3.Foreground = new SolidColorBrush(Colors.Black);
                Main4.Foreground = new SolidColorBrush(Colors.Black);
                Main5.Foreground = new SolidColorBrush(Colors.Black);
                Main6.Foreground = new SolidColorBrush(Colors.Black);
                Main7.Foreground = new SolidColorBrush(Colors.Black);
                Main8.Foreground = new SolidColorBrush(Colors.Black);
                Main10.Foreground = new SolidColorBrush(Colors.Black);
                Main11.Foreground = new SolidColorBrush(Colors.Black);
                Main12.Foreground = new SolidColorBrush(Colors.Black);
                Main13.Foreground = new SolidColorBrush(Colors.Black);
                Main14.Foreground = new SolidColorBrush(Colors.Black);
                Main15.Foreground = new SolidColorBrush(Colors.Black);
                stack1.Background = new SolidColorBrush(Colors.White);
                stack2.Background = new SolidColorBrush(Colors.White);
                stack3.Background = new SolidColorBrush(Colors.White);
                stack4.Background = new SolidColorBrush(Colors.White);
                stack5.Background = new SolidColorBrush(Colors.White);
                stack6.Background = new SolidColorBrush(Colors.White);
            }
        }

        private void Input1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ви дійсно хочете вийти?Якщо так - натисніть Ок");
            def = 0;
            if (def == 1)
            {
                Input.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Money.Visibility = Visibility.Visible;
                but1.Visibility = Visibility.Hidden;
                Input1.Visibility = Visibility.Visible;
            }
            else
            {
                Input.Visibility = Visibility.Visible;
                Reg.Visibility = Visibility.Visible;
                Money.Visibility = Visibility.Hidden;
                but1.Visibility = Visibility.Visible;
                Input1.Visibility = Visibility.Hidden;
            }
            change.Content = "Ел. почта/ номер телефону";
            Next.Visibility = Visibility.Visible;
            Next1.Visibility = Visibility.Hidden;
            Enter.Clear();
        }

        private void Money_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            RegistrMenu.Visibility = Visibility.Hidden;
            RegisMenu.Visibility = Visibility.Hidden;
            Cost.Visibility = Visibility.Visible;
            prof.Visibility = Visibility.Visible;

        }

        private void kard_Click(object sender, RoutedEventArgs e)
        {
            prof.Visibility = Visibility.Hidden;
            pov.Visibility = Visibility.Visible;
            if (f1 == 0)
            {
                BTC1.Background = new SolidColorBrush(Colors.White);
                BNB1.Background = new SolidColorBrush(Colors.White);
                USDT1.Background = new SolidColorBrush(Colors.White);
                BUSD1.Background = new SolidColorBrush(Colors.White);
                ETH1.Background = new SolidColorBrush(Colors.White);
            }
        }

        private void BTC1_Click(object sender, RoutedEventArgs e)
        {
            f1 = 1;

            BTC1.Background = new SolidColorBrush(Color.FromRgb(252, 213, 53));
            BNB1.Background = new SolidColorBrush(Colors.White);
            USDT1.Background = new SolidColorBrush(Colors.White);
            BUSD1.Background = new SolidColorBrush(Colors.White);
            ETH1.Background = new SolidColorBrush(Colors.White);

        }

        private void BNB1_Click(object sender, RoutedEventArgs e)
        {
            f1 = 2;
            BTC1.Background = new SolidColorBrush(Colors.White);
            BNB1.Background = new SolidColorBrush(Color.FromRgb(252, 213, 53));
            USDT1.Background = new SolidColorBrush(Colors.White);
            BUSD1.Background = new SolidColorBrush(Colors.White);
            ETH1.Background = new SolidColorBrush(Colors.White);
        }

        private void USDT1_Click(object sender, RoutedEventArgs e)
        {
            f1 = 3;
            BTC1.Background = new SolidColorBrush(Colors.White);
            BNB1.Background = new SolidColorBrush(Colors.White);
            USDT1.Background = new SolidColorBrush(Color.FromRgb(252, 213, 53));
            BUSD1.Background = new SolidColorBrush(Colors.White);
            ETH1.Background = new SolidColorBrush(Colors.White);
        }

        private void ETH1_Click(object sender, RoutedEventArgs e)
        {
            f1 = 4;
            BTC1.Background = new SolidColorBrush(Colors.White);
            BNB1.Background = new SolidColorBrush(Colors.White);
            USDT1.Background = new SolidColorBrush(Colors.White);
            BUSD1.Background = new SolidColorBrush(Colors.White);
            ETH1.Background = new SolidColorBrush(Color.FromRgb(252, 213, 53));
        }

        private void BUSD1_Click(object sender, RoutedEventArgs e)
        {

            BTC1.Background = new SolidColorBrush(Colors.White);
            BNB1.Background = new SolidColorBrush(Colors.White);
            USDT1.Background = new SolidColorBrush(Colors.White);
            BUSD1.Background = new SolidColorBrush(Color.FromRgb(252, 213, 53));
            ETH1.Background = new SolidColorBrush(Colors.White);
        }

        private void true1_Click(object sender, RoutedEventArgs e)
        {
            if (f1 > 0 & f1 <= 5 & Num1.Text != "")
            {
                pay1.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Помилка");
            }
            if (f1 == 1)
            {
                int b = Convert.ToInt32(Num1.Text);
                sum.Content = $"{b * 28000}$";
            }
            f1 = 0;

        }

        private void check1_Click(object sender, RoutedEventArgs e)
        {
            pay1.Visibility = Visibility.Hidden;
            pov.Visibility = Visibility.Hidden;
            Cost.Visibility = Visibility.Visible;
            prof.Visibility = Visibility.Visible;
            Num1.Clear();
        }

        void Registration()
        {
            if (f == 1)
            {
                if (RegInput1.Text != "" && RegInput2.Text != "")
                {
                    string strInsert = "INSERT INTO Registr(Gmail,Passwords) ";
                    string strValues = "VALUES('" + RegInput1.Text + "', '" + RegInput2.Text + "')";
                    using (SqlConnection connection = new SqlConnection(connect))
                    {
                        string str2 = strInsert + strValues;
                        connection.Open();
                        SqlCommand command = new SqlCommand(str2, connection);
                        int num = command.ExecuteNonQuery();
                        MessageBox.Show("Реєстрація прошла успішно");
                        RegInput1.Clear();
                        RegInput2.Clear();
                        MainMenu.Visibility = Visibility.Visible;
                        RegistrMenu.Visibility = Visibility.Hidden;
                        RegisMenu.Visibility = Visibility.Hidden;
                        if (def == 1)
                        {
                            Input.Visibility = Visibility.Hidden;
                            Reg.Visibility = Visibility.Hidden;
                            Money.Visibility = Visibility.Visible;
                            Input1.Visibility = Visibility.Visible;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }
            if (f == 2)
            {
                if (RegInput3.Text != "" && RegInput2.Text != "" && Convert.ToInt32(RegInput3.Text) >= 100000000 && Convert.ToInt32(RegInput3.Text) <= 999999999)
                {
                    string strInsert = "INSERT INTO Registr(Num,Passwords) ";
                    string strValues = "VALUES('" + "+380" + RegInput3.Text + "', '" + RegInput2.Text + "')";
                    using (SqlConnection connection = new SqlConnection(connect))
                    {
                        string str2 = strInsert + strValues;
                        connection.Open();
                        SqlCommand command = new SqlCommand(str2, connection);
                        int num = command.ExecuteNonQuery();
                        MessageBox.Show("Реєстрація прошла успішно");
                        RegInput1.Clear();
                        RegInput2.Clear();
                        MainMenu.Visibility = Visibility.Visible;
                        RegistrMenu.Visibility = Visibility.Hidden;
                        RegisMenu.Visibility = Visibility.Hidden;
                        if (def == 1)
                        {
                            Input.Visibility = Visibility.Hidden;
                            Reg.Visibility = Visibility.Hidden;
                            Money.Visibility = Visibility.Visible;
                            Input1.Visibility = Visibility.Visible;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }
        }
    }
}
