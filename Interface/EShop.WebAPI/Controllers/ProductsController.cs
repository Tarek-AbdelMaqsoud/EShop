using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EShop.Model;
using EShop.Business;
using EShop.Business.IRepositories.IProduct;
using System.Web.Http.Cors;
namespace EShop.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductService _productService { get; set; }

        public ProductsController(IProductService rep)
        {
            _productService = rep;
        }


        [HttpGet]
        [EnableCors(origins: "http://localhost:54566/", headers: "*", methods: "*")]
        public IEnumerable<Model.Product> GetAll()
        {
            try
            {
                return _productService.GetAll();
            }
            catch (Exception ex)
            {
                //Log To DB
            }
            return null;
        }

        

        [HttpPost]
        [EnableCors(origins: "http://localhost:54566", headers: "*", methods: "*")]
        public bool AddToCart(long productID)
        {
            //Add Cart To session
            return false;
        }
    }
}