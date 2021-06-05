using EcartAssiggmnet.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Services
{
    public interface ICatogryServices
    {
        IQueryable<Category> GetCategory();
        Category GetCategory(long id);
        void InsertCatogry(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
