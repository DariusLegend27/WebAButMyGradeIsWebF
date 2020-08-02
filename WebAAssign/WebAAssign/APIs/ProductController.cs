using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAAssign.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAAssign.APIs
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        public ApplicationDbContext Database
        {
            get;
        }

        public ProductController(ApplicationDbContext database)
        {
            Database = database;
        }

        // GET: api/<controller>
        [HttpGet("GetAllProd")]
        public IActionResult GetAllProd()
        {
            List<object> dataList = new List<object>();
            var prods = Database.Products.ToList();

            if (prods == null)
            {
                return NotFound(new
                {
                    message = "Unable to retrieve Category data"
                });
            }
            else
            {
                Debug.WriteLine("ENTERED ELSE STATEMENT");
                foreach (var prod in prods)
                {
                    dataList.Add(new
                    {
                        prodId = prod.prodId,
                        prodCode = prod.prodCode,
                        prodDesc = prod.prodDesc,
                        prodImgUrl = prod.prodImgUrl,
                        prodIngredients = prod.prodIngredients,
                        updatedBy = prod.updatedBy,
                        createdBy = prod.createdBy,
                        deletedBy = prod.deletedBy,
                        updatedAt = prod.updatedAt,
                        createdAt = prod.createdAt,
                        deletedAt = prod.deletedAt,
                        prodName = prod.prodName,
                        minQty = prod.minQty,
                        prodQty = prod.prodQty,
                        isPublished = prod.published
                    });
                }
            }
            return new JsonResult(dataList);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
