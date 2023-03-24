using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Lesson39_WPF_UsersApp1
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();

        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
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
            else
            {
                textBoxLogin.ToolTip = null;
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = null;
                passBox.Background = Brushes.Transparent;

                User authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault();
                }

                if (authUser != null)
                {
                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Something was wrong!!!");
                }
            }

        }

        private void Button_Register_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
