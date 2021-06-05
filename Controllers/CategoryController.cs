using EcartAssiggmnet.Data;
using EcartAssiggmnet.Data.Entity;
using EcartAssiggmnet.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Controllers
{
    [Route("[controller]/[action]")]
    public class CategoryController:Controller
    {
        private readonly ICatogryServices categoryService;
        private readonly IConfiguration config;
        private readonly UserManager<User> userManager;

        public CategoryController(ICatogryServices categoryService, IConfiguration config, UserManager<User> userManager)
        {
            this.categoryService = categoryService;
            this.config = config;
            this.userManager = userManager;
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IQueryable<Category> ShowCategories()
        {
           
                var CategoryList = categoryService.GetCategory();

            return CategoryList;

        }

        [HttpPost]
        public void CreateCategories(Category model)
        {
            var admin = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Category category = new Category
            {

                CategoryCode = model.CategoryCode,
                CategoryName = model.CategoryName,
                CreatedBy = admin,
                CreatedOn = DateTime.Today,
                UpdatedBy = admin,
                Updatedon = DateTime.Today,
                IsActive = true,
                IsDeleted = false


            };
            categoryService.InsertCatogry(category);

        }

        [HttpGet]
        public Category Edit(int id)
        {
            Category category = categoryService.GetCategory(id);
            return category;
            
        }

        [HttpDelete]
        public void Delete(int id)
        {
            Category category = categoryService.GetCategory(id);
            categoryService.DeleteCategory(category);
        }

        [HttpPut]
        public void UpdateCategory(Category model)
        {
            var admin = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Category category = categoryService.GetCategory(model.CategoryId);
            category.CategoryName = model.CategoryName;
            category.CategoryCode = model.CategoryCode;
            category.Updatedon = DateTime.Today;
            category.UpdatedBy = admin;
            categoryService.UpdateCategory(category);
        }

        

    }
}
