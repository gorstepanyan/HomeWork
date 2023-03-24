using System.Data.Entity;

namespace Lesson39_WPF_UsersApp1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }


    }
}
