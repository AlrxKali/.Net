using CatalogService.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        DatabaseContext _db;

        public CatalogController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _db.Products.ToList();
        }
    }
}
