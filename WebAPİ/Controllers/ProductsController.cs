using Business.Repository;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPİ.Models.ViewModels;

namespace WebAPİ.Controllers
{
    public class ProductsController : ApiController
    {
        BaseRepository<Product> _productRepository = new BaseRepository<Product>();


        public HttpResponseMessage GetAllProducts()
        {
            var products = _productRepository.GetAll().Select(x => new ProductVM
            {
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                ImagePath = x.ImagePath
            }).ToList();

            if (products != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, products);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Aradığınız ürün listesine ulaşılamıyor!");
            }
        }
    }
}
    

