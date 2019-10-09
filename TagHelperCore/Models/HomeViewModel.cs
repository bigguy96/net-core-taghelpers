using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TagHelperCore.Models
{
    public class HomeViewModel
    {
        public ICollection<SelectListItem> SelectedItems { get; set; }
    }
}
