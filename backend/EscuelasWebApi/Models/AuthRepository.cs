using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EscuelasWebApi.Models
{
    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<CustomUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<CustomUser>(new UserStore<CustomUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            try
            {
                var user = new CustomUser
                {
                    Email = userModel.UserName,
                    UserName = userModel.UserName,
                    SchoolCode = userModel.SchoolCode,
                    StudentCode = userModel.StudentCode,
                    Name = userModel.Name,
                    LastName = userModel.LastName
                };

                var result = await _userManager.CreateAsync(user, userModel.Password);

                return result;
            }
            catch (Exception ex)
            {
                
                throw;
            }
           
        }

        public async Task<CustomUser> FindUser(string userName, string password)
        {
            var user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}
