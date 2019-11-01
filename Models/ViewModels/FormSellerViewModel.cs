using System.Collections.Generic;

namespace SalesWebMvc22.Models.ViewModels
{
    public class FormSellerViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }


    }
}
