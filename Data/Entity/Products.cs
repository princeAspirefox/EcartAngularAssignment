using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Data.Entity
{
    public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string CategoryCode { get; set; }

        public string Description { get; set; }
        public string ImagePath { get; set; }

        public int Price { get; set; }

        public Category Category { get; set; }




    }
}

