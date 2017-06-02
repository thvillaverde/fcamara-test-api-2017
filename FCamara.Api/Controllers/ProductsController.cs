using FCamara.Domain.Entities;
using FCamara.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FCamara.Api.Controllers
{
    
    public class ProductsController : ApiController
    {
        ProductRepository _repository;

        public ProductsController()
        {
            _repository = new ProductRepository();
        }


        
        [Route("v1/products")]
        [HttpGet]
        [Authorize]
        public IEnumerable<Product> Get()
        {
            return _repository.Get();
        }
    }
}
