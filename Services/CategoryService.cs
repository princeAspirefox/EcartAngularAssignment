using EcartAssiggmnet.Data;
using EcartAssiggmnet.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Services
{
    public class CategoryService : ICatogryServices
    {
        
        private IRepository<Category> CategoryRepository;
        public CategoryService(IRepository<Category> CategoryRepository)
        {
            
            this.CategoryRepository = CategoryRepository;
        }

        public void DeleteCategory(Category category)
        {

            CategoryRepository.Delete(category);

        }

        public IQueryable<Category> GetCategory()
        {
            return CategoryRepository.Table;
        }

        public Category GetCategory(long id)
        {
            return CategoryRepository.GetById(id);
        }

        public void InsertCatogry(Category category)
        {
            CategoryRepository.Insert(category);
        }

        public void UpdateCategory(Category category)
        {
            CategoryRepository.Update(category);
        }
    }
}
