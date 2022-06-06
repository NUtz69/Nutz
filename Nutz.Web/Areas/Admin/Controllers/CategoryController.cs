using Microsoft.AspNetCore.Mvc;
using Nutz.DataAccess;
using Nutz.DataAccess.Repository.IRepository;
using Nutz.Models;

namespace Nutz.Web.Controllers
{
    // 001 - Repository Pattern
    [Area("Admin")]
    public class CategoryController : Controller
    {
        // Var
        private readonly IUnitOfWork _unitOfWork;

        // ctor
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Index
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _unitOfWork.Category.GetAll();

            return View(objCategoryList);
        }

        // Create

        // Get
        public IActionResult Create()
        {
            return View();
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            // asp-validation-summary
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }

            // Data
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";

                return RedirectToAction("Index");
            }

            return View(obj);

        }

        // Edit

        // Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var categoryFromDb = _db.Categories.Find(id);
            var categoryFromDbFirst = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryFromDbFirst == null)
            {
                return NotFound();
            }

            return View(categoryFromDbFirst);
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            // asp-validation-summary
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }

            // Data
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category updated successfully";

                return RedirectToAction("Index");
            }

            return View(obj);

        }

        // Delete

        // Get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var categoryFromDb = _db.Categories.Find(id);
            var categoryFromDbFirst = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryFromDbFirst == null)
            {
                return NotFound();
            }

            return View(categoryFromDbFirst);
        }

        // Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";

            return RedirectToAction("Index");
        }
    }
}
