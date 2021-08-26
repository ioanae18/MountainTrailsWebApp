namespace MountainTrailsWebApp.Migrations
{
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<MountainTrailsWebApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MountainTrailsWebApp.Models.ApplicationDbContext";
        }

        protected override void Seed(MountainTrailsWebApp.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            //context.Users.AddOrUpdate(new Models.ApplicationUser
            //{
            //    Email = "admin@yahoo.com",
            //    UserName = "admin@yahoo.com",
            //    FirstName = "admin",
            //    LastName = "admin"
            //});
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
