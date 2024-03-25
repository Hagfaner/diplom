using diplom.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace diplom.Pages
{
    [Authorize]
    public class UserModel : PageModel
    {
        private readonly UserManager<User> userManager;
        public User? user;

        public UserModel(UserManager<User> userManager) {
            this.userManager = userManager;
        }
        public void OnGet()
        {
            var task = userManager.GetUserAsync(User);
            task.Wait();
            user = task.Result;
        }
    }
}
