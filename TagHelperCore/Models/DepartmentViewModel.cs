using System.Collections.Generic;
using TagHelperCore.Entities;

namespace TagHelperCore.Models
{
    public class DepartmentViewModel
    {
        public int[] SelectedIds { get; set; }
        public IEnumerable<Store> Stores { get; set; }
    }
}
