using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TagHelperCore.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Telephone is required")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        public Dictionary<int, string> ValidationOrder { get; set; } = new Dictionary<int, string>()
        {
            {1,"FirstName" },
            {2,"LastName" },
            {3,"Telephone" },
            {4,"City" }
        };
    }
}