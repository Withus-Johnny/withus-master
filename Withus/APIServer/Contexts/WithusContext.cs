using APIServer.Entitys;
using Microsoft.EntityFrameworkCore;

namespace APIServer.Contexts
{
    public class WithusContext : DbContext
    {
        public WithusContext()
        {

        }

        public WithusContext(DbContextOptions<WithusContext> options)
        : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Tb_User_Info> table_user_info { get; set; }
    }
}
