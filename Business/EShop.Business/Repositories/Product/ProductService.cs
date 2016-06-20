using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Business.IRepositories.IProduct;
namespace EShop.Business.Repositories.Product
{
    public class ProductService : IRepositories.IProduct.IProductService
    {
        private IProductRepository _rep { get; set; }
        public ProductService(IRepositories.IProduct.IProductRepository rep)
        {
            _rep = rep;
        }

        public IEnumerable<Model.Product> GetAll()
        {
            return _rep.GetAll();
        }

        public Model.Product GetByID(long ID)
        {
            return _rep.GetByID(ID);
        }
    }
}
