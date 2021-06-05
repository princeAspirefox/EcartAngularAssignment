using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Data.Entity
{
    public class Category : BaseEntity
    {
        public int CategoryId { get; set; }
        [Required]
        public int CategoryCode { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
