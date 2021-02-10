using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.ViewModels
{
    public class ChangePasswordViewModel2
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter New Password!")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter the confirm password!")]
        [Compare("NewPassword", ErrorMessage ="New Password and Confirm Password do not match each other!")]
        public string ConfirmPassword { get; set; }

        public string UserId { get; set; }
    }
}
