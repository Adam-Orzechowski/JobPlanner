using JobPlanner.Common;
using JobPlanner.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JobPlanner.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserManagementController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
        }


        [HttpGet]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Index()
        {
            var users = _context.Users.ToList();
            var userListWithRoles = new List<UserWithRolesViewModel>();


            foreach (var user in users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                userListWithRoles.Add(new UserWithRolesViewModel
                {
                    User = user,
                    UserRoles = _roleManager.Roles.Select(role => new UserRights
                    {
                        UserRole = role.Name,
                        IsSelected = userRoles.Contains(role.Name)
                    }).ToList()
                });
            }

            return View(userListWithRoles);
        }

        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }
            var locations = _context.Locations.ToList();
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            var viewModel = new UserWithRolesViewModel
            {
                User = user,
                UserRoles = roles.Select(role => new UserRights
                {
                    UserRole = role.Name,
                    IsSelected = userRoles.Contains(role.Name)
                }).ToList(),
                UserLocations = locations.Select(location => new UserLoc
                {
                    
                    Location = location,
                    IsSelected = _context.UserLocations.Any(ul => ul.UserId == user.Id && ul.LocationId == location.Id)
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Edit(Guid id, UserWithRolesViewModel roles)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var selectedRoles = roles.UserRoles.Where(x => x.IsSelected).Select(x => x.UserRole).ToList();

            var result = await _userManager.RemoveFromRolesAsync(user, userRoles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Nie można usunąć roli użytkownika");
                return View("Edit", new { id });
            }
            result = await _userManager.AddToRolesAsync(user, selectedRoles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Nie można dodać roli użytkownikowi");
                return View("Edit", new { id });
            }
            //Nie da się wyłączyć userowi admin roli admin
            if (user.Id == "fc2bd771-13fc-48d0-8b82-cde1b74e8fbc")
            {
                _userManager.AddToRoleAsync(user, Roles.Admin);
            }

            _context.UserLocations.Remove(_context.UserLocations.FirstOrDefault(ul => ul.UserId == user.Id));

            var selecdedLocations = roles.UserLocations.Where(x => x.IsSelected).Select(x => x.Location.Id).ToList();
            foreach(var ul in selecdedLocations)
            {
                _context.UserLocations.Add(new UserLocation
                {
                    UserId = user.Id,
                    LocationId = ul
                });
            }
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public class UserLoc
        { 
            public Location Location { get; set; }
            public bool IsSelected { get; set; }
        }

        public class UserRights
        {
            public string UserRole { get; set; }
            public bool IsSelected { get; set; }
        }

        public class UserWithRolesViewModel
        {
            public ApplicationUser User { get; set; }
            public List<UserRights> UserRoles { get; set; }
            public List<UserLoc> UserLocations { get; set; }
        }
    }
}
