using CoreDataBaseAccessStyle_0.Models.ContextClasses;
using CoreDataBaseAccessStyle_0.Models.Entities;
using CoreDataBaseAccessStyle_0.Models.ViewModels.CategoryVMs.PureVMs.RequestModels;
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

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestModel model)
        {
            Category c = new Category()
            {
                CategoryName = model.CategoryName,
                Description = model.Description
            };
            _db.Categories.Add(c);
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }

        public IActionResult UpdateCategory(int id)
        {
            Category c = _db.Categories.Find(id);
            UpdateCategoryRequestModel uCVM = new()
            {
                CategoryName = c.CategoryName,
                Description = c.Description,
                CategoryId = c.CategoryId
            };
            

            return View(uCVM);
        }

        [HttpPost]
        public IActionResult UpdateCategory(UpdateCategoryRequestModel model)
        {
            
            Category c = _db.Categories.Find(model.CategoryId);
            c.CategoryId= model.CategoryId;
            c.CategoryName = model.CategoryName;
            c.Description = model.Description;

            _db.SaveChanges();

            return RedirectToAction("GetCategories");

            
        }

        public IActionResult DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetCategories");

        }
    }
}
