using Microsoft.AspNetCore.Mvc;
using Nutz.DataAccess.Repository.IRepository;
using Nutz.Utility;
using System.Security.Claims;

namespace Nutz.Web.ViewComponents
{
    // 008 - Advance Concepts
    public class ShoppingCartViewComponent : ViewComponent
    {
        // Var
        private readonly IUnitOfWork _unitOfWork;
        // ctor
        public ShoppingCartViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // If logIn get the session
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                if (HttpContext.Session.GetInt32(SD.SessionCart) != null)
                {
                    return View(HttpContext.Session.GetInt32(SD.SessionCart));
                }
                else
                {
                    HttpContext.Session.SetInt32(SD.SessionCart, _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value).ToList().Count);
                    return View(HttpContext.Session.GetInt32(SD.SessionCart));
                }
            }
            else
            {
                HttpContext.Session.Clear();
                return View(0);
            }
        }
    }
}
