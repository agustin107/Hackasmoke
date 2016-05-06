using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace EscuelasWebApi.Models
{
    public static class IdentityExtensions
    {
        public static async Task<CustomUser> FindByNameOrEmailAsync(this UserManager<CustomUser> userManager, string usernameOrEmail, string password)
        {
            var username = usernameOrEmail;
            if (usernameOrEmail.Contains("@"))
            {
                var userForEmail = await userManager.FindByEmailAsync(usernameOrEmail);
                if (userForEmail != null)
                {
                    username = userForEmail.UserName;
                }
            }
            var user = userManager.Find(username, password);
            return user;
        }
    }
}