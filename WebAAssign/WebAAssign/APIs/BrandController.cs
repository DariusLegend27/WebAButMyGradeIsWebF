using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAAssign.Data;
using WebAAssign.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAAssign.APIs
{
    [Route("api/[controller]")]
    public class BrandController : Controller
    {
        public ApplicationDbContext Database
        {
            get;
        }

        public BrandController(ApplicationDbContext database)
        {
            Database = database;
        }

        // GET: api/<controller>
        [HttpGet("GetAllBrand")]
        public IActionResult GetAllBrand()
        {
            List<object> dataList = new List<object>();
            var brands = Database.Brands.ToList();

            if (brands == null)
            {
                return NotFound(new
                {
                    message = "Unable to retrieve Brand data"
                });
            }
            else
            {
                Debug.WriteLine("ENTERED ELSE STATEMENT");
                foreach (var brand in brands)
                {
                    if (brand.deleted != 1)
                    {
                        dataList.Add(new
                        {
                            brandId = brand.brandId,
                            brandName = brand.brandName,
                            brandImgUrl = brand.brandImgUrl,
                            deleted = brand.deleted,
                            createdBy = brand.createdBy,
                            updatedBy = brand.updatedBy,
                            deletedBy = brand.deletedBy,
                            createdAt = brand.createdAt,
                            updatedAt = brand.updatedAt,
                            deletedAt = brand.deletedAt
                        });
                    }
                }
            }
            return new JsonResult(dataList);
        }

        // GET api/Students/5
        [HttpGet("GetOneBrand/{brandName}")]
        public IActionResult Get(string brandName)
        {//SingleOrDefault returns either null or an object
            var oneBrand = Database.Brands
            .SingleOrDefault(brand => brand.brandName == brandName);
            if (oneBrand == null)
            {
                return BadRequest(new { message = "Unable to retrieve Brand data" });
            }
            else
            {
                var response = new
                {
                    brandId = oneBrand.brandId,
                };
                //end of creation of the anonymous type response object
                return Ok(response);
            }//end of if..else
        }//End of Get(id) method

        // GET api/Students/5
        [HttpGet("GetABrand/{id}")]
        public IActionResult GetABrand(int id)
        {//SingleOrDefault returns either null or an object
            var oneBrand = Database.Brands
            .Include(cb => cb.categoryBrands)
            .SingleOrDefault(brand => brand.brandId == id);

            List<int> catId = new List<int>();

            if (oneBrand == null)
            {
                return BadRequest(new { message = "Unable to retrieve Brand data" });
            }
            else
            {
                foreach (CategoryBrand CB in oneBrand.categoryBrands)
                {
                    catId.Add(CB.catId);
                }
                var response = new
                {
                    brandName = oneBrand.brandName,
                    categories = catId
                };
            //end of creation of the anonymous type response object
            return Ok(response);
        }//end of if..else
    }//End of Get(id) method

    //Add Category
    [HttpPost("AddBrand")]
    public IActionResult Post([FromForm]IFormCollection data)
    {
        string customMessage = "";

        //create Student object
        Brand newBrand = new Brand()
        {
            categoryBrands = new List<CategoryBrand>()
        };

        //Create a new category brand object
        CategoryBrand categoryBrand;

        //Passing data into newStudent
        newBrand.brandName = data["brandName"];
        newBrand.createdAt = DateTime.Now;
        newBrand.updatedAt = DateTime.Now;

        Debug.WriteLine("What's in selected cats : " + data["selectedCats"]);

        //For each catId in array add
        foreach (string catId in data["selectedCats"])
        {
            categoryBrand = new CategoryBrand();
            categoryBrand.catId = Convert.ToInt32(catId);
            newBrand.categoryBrands.Add(categoryBrand);
        }
        try
        {
            //Add newStudent object
            Database.Add(newBrand);

            //Save changess
            Database.SaveChanges();
            Debug.WriteLine("CHANGES TO BRANDS TABLE SAVED");
        }
        catch (Exception ex)
        {
            if (ex.InnerException != null)
            {
                if (ex.InnerException.Message.Contains("Brand_brandId_UniqueConstraint") == true)
                {
                    customMessage = "Unable to save Brand record due to another record having the same id: " + data["brandId"];
                    return BadRequest(new { message = customMessage });
                }
                else
                {
                    customMessage = "Unable to save Brand record due to internal server errors";
                    return BadRequest(new { message = customMessage });
                }
            }
            else
            {
                Debug.WriteLine("THE EXCEPTION IS " + ex);
            }
        }


        return Ok(new
        {
            message = "Saved Brand Record"
        });
    }

    //Add Category
    [HttpPost("AddCategoryBrand")]
    public IActionResult AddCB([FromForm]IFormCollection data)
    {
        string customMessage = "";

        //create Student object
        CategoryBrand newCB = new CategoryBrand();

        //Passing data into newStudent
        newCB.catId = Convert.ToInt32(data["catId"]);
        newCB.brandId = Convert.ToInt32(data["brandId"]);

        try
        {
            //Add newStudent object
            Database.Add(newCB);

            //Save changess
            Database.SaveChanges();
        }
        catch (Exception ex)
        {
            if (ex.InnerException != null)
            {
                if (ex.InnerException.Message.Contains("CategoryBrand_cbId_UniqueConstraint") == true)
                {
                    customMessage = "Unable to save Category Brand record due to another record having the same id: " + data["cbId"];
                    return BadRequest(new { message = customMessage });
                }
                else
                {
                    customMessage = "Unable to save Category Brand record due to internal server errors";
                    return BadRequest(new { message = customMessage });
                }
            }
            else
            {
                Debug.WriteLine("THE EXCEPTION IS " + ex);
                customMessage = "Unable to save Category Brand record due to internal server errors";
                return BadRequest(new { message = customMessage });
            }
        }

        return Ok(new
        {
            message = "Saved Brand Record"
        });
    }

        // PUT api/<controller>/5
        [HttpPut("UpdateBrand/{id}")]
        public IActionResult Put(int id, [FromForm]IFormCollection data)
        {
            string customMessage = "";
            //Using SingleOrDefault method instead of Single method

            Brand foundOneBrand = Database.Brands
                .Include(cb => cb.categoryBrands)
                .SingleOrDefault(oneBrand => oneBrand.brandId == id);

            if (foundOneBrand != null)
            {
                //Passing data into newStudent
                foundOneBrand.brandName = data["brandName"];
                //Convert Datetime datatype first
                foundOneBrand.updatedAt = DateTime.Now;
            }
            else
            {
                return NotFound(new { message = "Unable to update the Brand information. " });
            }
            try
            {  //Call the Update method and pass the foundOneStudent object into it
                Database.Brands.Update(foundOneBrand);
                //Tell the ApplicationDbContext object (referenced by the Database property)
                //to make the changes permanent in the database.
                Database.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message
                      .Contains("Category_catId__UniqueConstraint") == true)
                {
                    customMessage = "Unable to save student record due " +
                       "to another record having the same category id : " +
                    data["catId"];
                    //Give a response with status 400 (client-side understands
                    //it is a bad request and the operation has failed).
                    return BadRequest(new { message = customMessage });
                }
            }//End of try .. catch block on saving data
             //Give a response with status 200. At the same time, attach 
             //a JSON data
            return Ok(new { message = "Saved Brand record" });

        }//End of Put web api  

        // PUT api/Students/5
        [HttpPut("SoftDelete/{id}")]
    public IActionResult SD(int id, [FromForm]IFormCollection data)
    {
        string customMessage = "";
        //Using SingleOrDefault method instead of Single method
        Brand foundOneBrand = Database.Brands
            .SingleOrDefault(oneBrand => oneBrand.brandId == id);
        if (foundOneBrand != null)
        {
            //Passing data into newStudent
            foundOneBrand.deleted = 1;

            //Convert Datetime datatype first
            foundOneBrand.updatedAt = DateTime.Now;
            foundOneBrand.deletedAt = DateTime.Now;
        }
        else
        {
            return NotFound(new { message = "Unable to update the Brand information. " });
        }
        try
        {  //Call the Update method and pass the foundOneStudent object into it
            Database.Brands.Update(foundOneBrand);
            //Tell the ApplicationDbContext object (referenced by the Database property)
            //to make the changes permanent in the database.
            Database.SaveChanges();
        }
        catch (Exception ex)
        {
            if (ex.InnerException.Message
                  .Contains("Category_catId__UniqueConstraint") == true)
            {
                customMessage = "Unable to save student record due " +
                   "to another record having the same category id : " +
                data["catId"];
                //Give a response with status 400 (client-side understands
                //it is a bad request and the operation has failed).
                return BadRequest(new { message = customMessage });
            }
        }//End of try .. catch block on saving data
         //Give a response with status 200. At the same time, attach 
         //a JSON data
        return Ok(new { message = "Soft Deleted Category record" });

    }//End of Put web api  

    // DELETE api/<controller>/5
    //Note: If there are missing value at the end of the URL
    //it is 404 not found. There won't be any run time error caused.
    [HttpDelete("HardDelete/{id}")]
    public IActionResult Delete(int id)
    {
        string customMessage = "";

        try
        {
            var foundOneBrand = Database.Brands
            .SingleOrDefault(oneBrand => oneBrand.brandId == id);
            //Call the remove method, pass the foundOneStudent object into it
            //so that the Database object knows what to remove from the database.
            Database.Brands.Remove(foundOneBrand);
            //Tell the db model to commit/persist the changes to the database, 
            //I use the following command.
            Database.SaveChanges();
        }
        catch (Exception ex)
        {
            customMessage = "Unable to delete Brand record due to " + ex;
            return BadRequest(new { message = customMessage });
        }//End of try .. catch block on manage data

        return Ok(new { message = "Deleted Brand record" });
    }//end of Delete() Web API method
}
}
