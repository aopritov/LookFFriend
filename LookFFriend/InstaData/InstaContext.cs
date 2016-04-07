using System.Data.Entity;
using InstaData.InstaModels;

namespace InstaData
{
    public partial class InstaContext : DbContext
    {
        public InstaContext()
            : base("name=InstaDBConnectionString")
        {
            Database.SetInitializer(new InstaDBInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
    }
}
