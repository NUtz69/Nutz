using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nutz.DataAccess;
using Nutz.DataAccess.Respository;
using Nutz.DataAccess.Respository.IRespository;
using Nutz.Models;
using Nutz.Models.ViewModels;

namespace Nutz.Web.Controllers
{
    // 004 - Identity Management
    [Area("Admin")]
    public class CompanyController : Controller
    {
        // Var
        private readonly IUnitOfWork _unitOfWork;

        // ctor
        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Index
        public IActionResult Index()
        {
            return View();
        }

        // Edit

        // Get
        public IActionResult Upsert(int? id)
        {
            // Var
            Company company = new();

            if (id == null || id == 0)
            {
                return View(company);
            }
            else
            {
                // Update Company
                company = _unitOfWork.Company.GetFirstOrDefault(p => p.Id == id);

                return View(company);
            }
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Company obj, IFormFile? file)
        {
            // Data
            if (ModelState.IsValid)
            {
                // Add
                if (obj.Id == 0)
                {
                    _unitOfWork.Company.Add(obj);
                    TempData["success"] = "Company created successfully !";
                }
                else
                {
                    _unitOfWork.Company.Update(obj);
                    TempData["success"] = "Company updated successfully !";
                }
                _unitOfWork.Save();

                return RedirectToAction("Index");
            }

            return View(obj);

        }

        // Delete

        // region

        // Get
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var companyList = _unitOfWork.Company.GetAll();

            return Json(new { data = companyList });
        }

        // Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var obj = _unitOfWork.Company.GetFirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting !" });
            }

            _unitOfWork.Company.Remove(obj);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful !" });
        }
        #endregion
    }
}
