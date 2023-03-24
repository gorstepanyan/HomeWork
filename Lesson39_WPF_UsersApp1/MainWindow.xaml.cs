using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Lesson39_WPF_UsersApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            DoubleAnimation btnAnimation = new DoubleAnimation();
            btnAnimation.From = 0;
            btnAnimation.To = 450;
            btnAnimation.Duration = TimeSpan.FromSeconds(2);
            regButton.BeginAnimation(WidthProperty, btnAnimation);
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Դաշտը ճիշտ չէ լրացված";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Դաշտը ճիշտ չէ լրացված";
                passBox.Background = Brushes.DarkRed;
            }
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "Դաշտը ճիշտ չէ լրացված";
                passBox_2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Դաշտը ճիշտ չէ լրացված";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = null;
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = null;
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = null;
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = null;
                textBoxEmail.Background = Brushes.Transparent;

                User user = new User(login, pass, email);
                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show("Greate Job!!!");
                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Hide();

            }

        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }
    }
}
