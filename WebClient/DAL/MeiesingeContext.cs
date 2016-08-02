using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Meiesinge.WebClient.Models;

namespace Meiesinge.WebClient.DAL
{
    public class MeiesingeContext : DbContext
    {

        public MeiesingeContext() : base("MeiesingeContext")
        {
        }

        public DbSet<Invitee> Invitees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}