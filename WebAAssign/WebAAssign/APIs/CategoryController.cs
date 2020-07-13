using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using WebAAssign.Data;
using WebAAssign.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAAssign.APIs
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        public ApplicationDbContext Database
        {
            get;
        }

        public CategoryController(ApplicationDbContext database)
        {
            Database = database;
        }

        // GET: api/<controller>
        [HttpGet("GetAllCat")]
        public IActionResult GetAllCat()
        {
            List<object> dataList = new List<object>();
            var cats = Database.Categories
                .Include(cat => cat.visibility)
                .ToList();

            if (cats == null)
            {
                return NotFound(new
                {
                    message = "Unable to retrieve Category data"
                });
            }
            else
            {
                Debug.WriteLine("ENTERED ELSE STATEMENT");
                foreach (var cat in cats)
                {
                    if (cat.deleted == 0)
                    {
                        dataList.Add(new
                        {
                            catId = cat.catId,
                            catName = cat.catName,
                            createdAt = cat.createdAt,
                            createdBy = cat.createdBy,
                            updatedAt = cat.updatedAt,
                            updatedBy = cat.updatedBy,
                            visibility = cat.visibility.visRole,
                        });
                    }
                }
            }
            return new JsonResult(dataList);
        }

        // GET api/Students/5
        [HttpGet("GetOneCat/{id}")]
        public IActionResult Get(int id)
        {//SingleOrDefault returns either null or an object
            var oneCategory = Database.Categories
            .Include(cat => cat.visibility)
            .SingleOrDefault(cat => cat.catId == id);
            if (oneCategory == null)
            {
                return BadRequest(new { message = "Unable to retrieve Category data" });
            }
            else
            {
                var response = new
                {
                    catId = oneCategory.catId,
                    catName = oneCategory.catName,
                    startDate = oneCategory.startDate,
                    endDate = oneCategory.endDate,
                    visibility = oneCategory.visId,
                };
                //end of creation of the anonymous type response object
                return Ok(response);
            }//end of if..else
        }//End of Get(id) method

        //Add Category
        [HttpPost("AddCat")]
        public IActionResult Post([FromForm]IFormCollection data)
        {
            string customMessage = "";

            //create Student object
            Category newCategory = new Category();

            //Passing data into newStudent
            newCategory.catName = data["catName"];

            //Convert Datetime datatype first
            newCategory.startDate = DateTime.ParseExact(data["startDate"], "yyyy-mm-dd", CultureInfo.InvariantCulture);
            newCategory.endDate = DateTime.ParseExact(data["endDate"], "yyyy-mm-dd", CultureInfo.InvariantCulture);
            newCategory.visId = Convert.ToInt32(data["visId"]);

            // Will be changed to Convert.ToInt32(data["specialCat"]) in the future
            newCategory.specialCat = 0;

            // Will be changed into Convert.ToInt32(data["deleted"])
            newCategory.deleted = 0;
            newCategory.createdAt = DateTime.Now;
            newCategory.updatedAt = DateTime.Now;

            try
            {
                //Add newStudent object
                Database.Add(newCategory);

                //Save changes
                Database.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    if (ex.InnerException.Message.Contains("Category_catId_UniqueConstraint") == true)
                    {
                        customMessage = "Unable to save Category record due to another record having the same id: " + data["catId"];
                        return BadRequest(new { message = customMessage });
                    }
                    else
                    {
                        customMessage = "Unable to save student record due to internal server errors";
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
                message = "Saved Category Record"
            });
        }

        // PUT api/Students/5
        [HttpPut("UpdateCat/{id}")]
        public IActionResult Put(int id, [FromForm]IFormCollection data)
        {
            string customMessage = "";
            //Using SingleOrDefault method instead of Single method
            Category foundOneCategory = Database.Categories
                .Include(cat => cat.visibility)
                .SingleOrDefault(oneCat => oneCat.catId == id);
            if (foundOneCategory != null)
            {
                //Passing data into newStudent
                foundOneCategory.catName = data["catName"];

                //Convert Datetime datatype first
                foundOneCategory.startDate = DateTime.ParseExact(data["startDate"], "yyyy-mm-dd", CultureInfo.InvariantCulture);
                foundOneCategory.endDate = DateTime.ParseExact(data["endDate"], "yyyy-mm-dd", CultureInfo.InvariantCulture);
                foundOneCategory.visId = Convert.ToInt32(data["visId"]);
                foundOneCategory.updatedAt = DateTime.Now;      }
            else
            {
                return NotFound(new { message = "Unable to update the Category information. " });
            }
            try
            {  //Call the Update method and pass the foundOneStudent object into it
                Database.Categories.Update(foundOneCategory);
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
            return Ok(new { message = "Saved Category record" });

        }//End of Put web api  

        // PUT api/Students/5
        [HttpPut("SoftDelete/{id}")]
        public IActionResult SD(int id, [FromForm]IFormCollection data)
        {
            string customMessage = "";
            //Using SingleOrDefault method instead of Single method
            Category foundOneCategory = Database.Categories
                .Include(cat => cat.visibility)
                .SingleOrDefault(oneCat => oneCat.catId == id);
            if (foundOneCategory != null)
            {
                //Passing data into newStudent
                foundOneCategory.deleted = 1;

                //Convert Datetime datatype first
                foundOneCategory.updatedAt = DateTime.Now;
                foundOneCategory.deletedAt = DateTime.Now;
            }
            else
            {
                return NotFound(new { message = "Unable to update the Category information. " });
            }
            try
            {  //Call the Update method and pass the foundOneStudent object into it
                Database.Categories.Update(foundOneCategory);
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
                var foundOneCategory = Database.Categories
                .SingleOrDefault(oneCat => oneCat.catId == id);
                //Call the remove method, pass the foundOneStudent object into it
                //so that the Database object knows what to remove from the database.
                Database.Categories.Remove(foundOneCategory);
                //Tell the db model to commit/persist the changes to the database, 
                //I use the following command.
                Database.SaveChanges();
            }
            catch (Exception ex)
            {
                customMessage = "Unable to delete Category record due to " + ex;
                return BadRequest(new { message = customMessage });
            }//End of try .. catch block on manage data

            return Ok(new { message = "Deleted Category record" });
        }//end of Delete() Web API method
    }
}
