using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EscuelasWebApi.Models
{
    public class CustomUser : IdentityUser
    {
        [Required(ErrorMessage = "Nombre Requerido.")]
        [Display(Name = "Name")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Apellido Requerido.")]
        [Display(Name = "LastName")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string LastName { get; set; }

        public string SchoolCode { get; set; }

        public string StudentCode { get; set; }


    }

}
