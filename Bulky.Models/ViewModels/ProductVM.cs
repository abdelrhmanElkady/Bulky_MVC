using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bulky.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } = null!;
        public IEnumerable<SelectListItem> CategoryList { get; set; } = new List<SelectListItem>();
    }
}
