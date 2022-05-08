using Nutz.DataAccess.Respository.IRespository;
using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository
{
    // 002 - Product Management
    public class ProductRespository : Respository<Product>, IProductRespository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public ProductRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // Update
        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(x => x.Id == obj.Id);

            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Author = obj.Author;
                objFromDb.CoverTypeId = obj.CoverTypeId;

                // Image
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
