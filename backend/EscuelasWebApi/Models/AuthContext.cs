using Microsoft.AspNet.Identity.EntityFramework;

namespace EscuelasWebApi.Models
{
    public class AuthContext : IdentityDbContext<CustomUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}