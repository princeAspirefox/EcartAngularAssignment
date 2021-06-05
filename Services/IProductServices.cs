using EcartAssiggmnet.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Services
{
    public interface IProductServices
    {
        IQueryable<Product> Getproducts();
        Product GetProduct(long id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);



    }
}
