using EcartAssiggmnet.Data;
using EcartAssiggmnet.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Services
{
    public class ProductServices : IProductServices
    {
        private IRepository<Product> ProductRepository;
        

        public ProductServices(IRepository<Product> ProductRepository, IRepository<Category> CategoryRepository)
        {
            this.ProductRepository = ProductRepository;
            
        }



        public Product GetProduct(long id)
        {
            return ProductRepository.GetById(id);
        }

        public void InsertProduct(Product user)
        {
            ProductRepository.Insert(user);
        }

        public void UpdateProduct(Product user)
        {
            ProductRepository.Update(user);
        }

        public void DeleteProduct(Product user)
        {

            ProductRepository.Delete(user);
        }



        public IQueryable<Product> Getproducts()
        {
            return ProductRepository.Table;
        }
    }
}
