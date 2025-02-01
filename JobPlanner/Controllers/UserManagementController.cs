using JobPlanner.Common;
using JobPlanner.Data;
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
                //UserLocations = locations.Select(location => new UserLocations
                //{
                //    LocationGuid = location.Id,
                //    LocationName = location.Name,
                //    //IsSelected = user.Claims.Any(x => x.ClaimType == ClaimTypes.Location && x.ClaimValue == location.LocationGuid.ToString())
                //}).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
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
            if (user.Id == "fc2bd771-13fc-48d0-8b82-cde1b74e8fbc")
            {
                _userManager.AddToRoleAsync(user, Roles.Admin);
            }

            return RedirectToAction("Index");
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
            //public List<UserLocations> UserLocations { get; set; }
        }
    }
}
