using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdsMarketplace.Domain.Abstract;
using AdsMarketplace.Domain.Entities;
using AdsMarketplace.WebUI.Models;

namespace AdsMarketplace.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repository;
        public CategoryController(ICategoryRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            CategoryListModel model = new CategoryListModel
            {
                TopCategories = repository.TopCategories
            };
            return View(model);
        }
        //look in projects for subcat realisation
        public ViewResult SubCategoriesList(int? id)
        {
            CategoryModel model = new CategoryModel(repository.TopCategories.FirstOrDefault(c => c.TopCategoryId == id));
            
            return View(model);
        }
    }
}