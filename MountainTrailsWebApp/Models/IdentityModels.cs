using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MountainTrailsWebApp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //sunt obligatorii aici pentru ca altfel Entity Framework nu va stii ca aceste
        //entitati create vrem sa fie transferate catre BD
        public DbSet<CountyModels> Counties { get; set; }
        public DbSet<DifficultyModels> Difficulties { get; set; }
        public DbSet<MarkingModels> Markings { get; set; }
        public DbSet<MountainModels> Mountains { get; set; }
        public DbSet<PeakModels> Peaks { get; set; }
        public DbSet<SeasonModels> Seasons { get; set; }
        public DbSet<TrailModels> Trails { get; set; }
        public DbSet<NoPeopleArr1020Models> NoPeopleArr1020 { get; set; }
        public DbSet<NoPeopleArrMR20Models> NoPeopleArrMR20 { get; set; }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}