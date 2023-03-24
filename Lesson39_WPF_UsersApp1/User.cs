namespace Lesson39_WPF_UsersApp1
{
    public class User
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(string login, string pass, string email)
        {
            Login = login;
            Pass = pass;
            Email = email;
        }

        //public override string ToString()
        //{
        //    return $"User: {login}. Email: {email}";
        //}

    }
}
