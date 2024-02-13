using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataAccess.ViewModel
{
   
        public class LoginUser
        {
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid Email Address")]
       public string email { get; set; } = null;

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8,ErrorMessage ="Password must be atleast 8 characters long")]
        public string password { get; set; } = null;

        }
    }


