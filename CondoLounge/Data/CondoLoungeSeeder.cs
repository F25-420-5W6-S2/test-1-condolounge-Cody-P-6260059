using CondoLounge.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace CondoLounge.Data
{
    public class CondoLoungeSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public CondoLoungeSeeder(ApplicationDbContext context,
                IWebHostEnvironment hosting,
                UserManager<ApplicationUser> userManager,
                RoleManager<IdentityRole<int>> roleManager)
        {
            _db = context;
            _hosting = hosting;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            _db.Database.EnsureCreated();

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
            }

            if (!_userManager.Users.Any())
            {
                var user = new ApplicationUser() { UserName = "admin@email.com", Email = "admin@email.com" };
                await _userManager.CreateAsync(user, "VerySecureAdmin45%");
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            // seed data
            var building = new Building()
            {
                BuildingId = 1,
                Condos = new List<Condo>(){
                    new Condo()
                    {
                        CondoId = 1,
                        location = "Top",
                        CondoNumber = 100,
                        CondoIdNumber = 1
                    }
                }
            };

            _db.Building.Add(building);
            _db.SaveChanges();
        }
    }
}
