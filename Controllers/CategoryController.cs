using Microsoft.AspNetCore.Mvc;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
            public CategoryController(ApplicationDbContext db) {
            _db = db;
                }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Catagories.ToList();
            return View(objCategoryList);
        }
    }
}
