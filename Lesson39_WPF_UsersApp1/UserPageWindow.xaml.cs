using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Lesson39_WPF_UsersApp1
{
    /// <summary>
    /// Interaction logic for UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            listOfUsers.ItemsSource = users;
        }
    }
}
