using CoreDataBaseAccessStyle_0.Models.ContextClasses;
using CoreDataBaseAccessStyle_0.Models.Entities;
using CoreDataBaseAccessStyle_0.Models.ViewModels.CategoryVMs.PureVMs.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreDataBaseAccessStyle_0.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _db;
        public CategoryController(NorthwindContext db)
        {
            _db = db;
        }

        public IActionResult GetCategories()
        {
            List<CategoryResponseModel> categories = _db.Categories.Select(x => new CategoryResponseModel
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();

            return View(categories);
        }
    }
}
