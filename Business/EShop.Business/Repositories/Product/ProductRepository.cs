using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Business.IRepositories.IProduct;
using EShop.Model;
using EShop.Data;

namespace EShop.Business.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        private EShopDbContext _db { get; set; }
        public ProductRepository()
        {
            _db = new EShopDbContext();
        }

        public IEnumerable<Model.Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public Model.Product GetByID(long ID)
        {
            return _db.Products.Where(p=>p.ProductID == ID).FirstOrDefault();
        }
    }
}
