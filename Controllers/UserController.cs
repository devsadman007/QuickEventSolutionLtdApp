using Microsoft.AspNetCore.Mvc;
using QuickEventSolutionLtdApp.Models;
using QuickEventSolutionLtdApp.Utils;

namespace QuickEventSolutionLtdApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
           var users = GetUsersList();
            return View(users);
        }

        private List<UserViewModel> GetUsersList() 
        {
            List<UserViewModel> users = new List<UserViewModel>();
            UserViewModel user1 = new UserViewModel()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                ContactNumber = "1234567890",
                Email = "jone.doe@gmail.com",
                UserType = UserTypeEnum.Admin
            };
            UserViewModel user2 = new UserViewModel()
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                ContactNumber = "0987654321",
                Email = "jane.smith@gmail.com",
                UserType = UserTypeEnum.Standard

            };
            UserViewModel user3 = new UserViewModel()
            {
                Id = 3,
                FirstName = "Bob",
                LastName = "Johnson",
                ContactNumber = "5555555555",
                Email = "Bob.johnson@gmail.com",
                UserType = UserTypeEnum.Guest
            };

            UserViewModel user4 = new UserViewModel()
            {
                Id = 4,
                FirstName = "Alice",
                LastName = "Wilson",
                ContactNumber = "589878952",
                Email = "alice.johnson@gmail.com",
                UserType = UserTypeEnum.External
            };
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            return users;

        }
    }
}
