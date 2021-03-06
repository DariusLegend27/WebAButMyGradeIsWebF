﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAAssign.Data;
using WebAAssign.Models;
using System.Net.Http.Headers;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Cloudinary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAAssign.APIs
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private const string UPLOAD_PRESET = "upload_to_weba";
        public ApplicationDbContext Database
        {
            get;
        }

        public ProductController(ApplicationDbContext database)
        {
            Database = database;
        }

        //Cloudinary Upload picture
        //[HttpPost("SaveFiles")]
        //public async Task<IActionResult> SaveFiles(IList<IFormFile> fileInput, IFormCollection formData)
        //{
        //    string customMessage = "";
        //    int currentUserId = int.Parse(User.FindFirst("userid").Value);
        //    //Collect data from the body of the HTTP request
        //    LogFile logFile = new LogFile();
        //    int fileCount = 0;
        //    //http://weblogs.asp.net/imranbaloch/file-upload-in-aspnet5-mvc6 
        //    foreach (IFormFile oneFile in fileInput)
        //    {
        //        if (oneFile != null)
        //        {
        //            var fileName = ContentDispositionHeaderValue
        //                        .Parse(oneFile.ContentDisposition)
        //                        .FileName
        //                        .Trim('"');
        //            string contentType = oneFile.ContentType;
        //            try
        //            {
        //                //http://stackoverflow.com/questions/16392751/unable-to-cast-base-class-data-contract-to-derived-class
        //                logFile = await CloudinaryAPIs.
        //                UploadFileToCloudinary<LogFile>(UPLOAD_PRESET, oneFile.OpenReadStream(),
        //                contentType, fileName);
        //                logFile.Description = formData["description"];
        //                logFile.StudentId = currentUserId;
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //            if (logFile.PublicCloudinaryId != "")
        //            {
        //                _database.LogFiles.Add(logFile);
        //                _database.SaveChanges();
        //                fileCount += 1;
        //            }
        //            else
        //            {
        //                return BadRequest(new { message = "Unable to save file" });
        //            }

        //        }//end of checking if there is a file for upload
        //    }
        //    customMessage += String.Format("Saved {0} Files.", fileCount);
        //    return Ok(new { message = customMessage, record = logFile });

        //}//End of SaveFiles()



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
        //Add Category
        [HttpPost("AddProduct")]
        public async Task<IActionResult> Post(IFormCollection data, IList<IFormFile> fileInput)
        {
            //Initialize Variables
            string customMessage = "";
            int fileCount = 0;
            string url= "";

            //create Product object
            Product newProduct = new Product()
            {
                productDetails = new List<productDetail>(),
                productDiscountRates = new List<productDiscountRate>()
            };

            //Create a new discountRate, productDetail and productDiscountRate object
            discountRate newDiscountRate = new discountRate();
            productDetail newProductDetail = new productDetail();
            productDiscountRate newProductDiscountRate = new productDiscountRate();

            //Passing data into newProduct
            //Required Fields
            newProduct.prodName = data["prodName"];
            newProduct.prodCode = data["prodCode"];
            
            //newProduct.prodImgUrl = data["prodImgUrl"];
            newProduct.brandId = Convert.ToInt32(data["brandId"]);
            newProduct.createdAt = DateTime.Now;


            //Image
            LogFile logFile = new LogFile();
            foreach (IFormFile oneFile in fileInput)
            {
                if (oneFile != null)
                {
                    var fileName = ContentDispositionHeaderValue
                                .Parse(oneFile.ContentDisposition)
                                .FileName
                                .Trim('"');
                    string contentType = oneFile.ContentType;
                    try
                    {
                        //http://stackoverflow.com/questions/16392751/unable-to-cast-base-class-data-contract-to-derived-class
                        logFile = await CloudinaryAPIs.
                        UploadFileToCloudinary<LogFile>(UPLOAD_PRESET, oneFile.OpenReadStream(),
                        contentType, fileName);
                        logFile.Description = data["description"];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    if (logFile.PublicCloudinaryId != "")
                    {
                        url = logFile.Url;
                        Database.LogFiles.Add(logFile);
                        Database.SaveChanges();
                        fileCount += 1;
                    }
                    else
                    {
                        return BadRequest(new { message = "Unable to save file" });
                    }

                    
                }//end of checking if there is a file for upload
            }
            newProduct.prodImgUrl = url;

            //Optional Fields
            newProduct.guaranteedAnalysis = data["GA"];
            newProduct.prodDesc = data["prodDesc"];
            newProduct.prodIngredients = data["prodIng"];
            newProduct.updatedBy = data["updatedBy"];
            newProduct.createdBy = data["createdBy"];
            //newProduct.minQty = Convert.ToInt32(data["minQty"]);
            //newProduct.prodQty = Convert.ToInt32(data["prodQty"]);
            if (data["published"].Count != 0)
            {
                newProduct.published = Convert.ToInt32(data["published"]);
            }
            newProduct.updatedAt = DateTime.Now;

            //List of prices
            var priceArray = data["price"].ToArray();
            List<String[]> priceAttributes = new List<String[]>();
            Debug.WriteLine("PRICE DATA " + priceArray[0] + " AND " + priceArray[0][0]);



            try
            {
                //Add newStudent object
                Database.Add(newProduct);

                //Save changess
                Database.SaveChanges();
                Debug.WriteLine("CHANGES TO PRODUCT TABLE SAVED");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    if (ex.InnerException.Message.Contains("Product_prodName_UniqueConstraint") == true)
                    {
                        customMessage = "Unable to save Product record due to another record having the same name: " + data["prodName"];
                        return BadRequest(new { message = customMessage });
                    }
                    else
                    {
                        customMessage = "Unable to save Product record due to internal server errors";
                        return BadRequest(new { message = customMessage });
                    }
                }
                else
                {
                    Debug.WriteLine("THE EXCEPTION IS " + ex);
                }
            }


            ////For each price input in array price
            for (int i = 0; i < priceArray.Length; i++)
            {
                try
                {
                    priceAttributes.Add(priceArray[i].Split(","));
                    for (int j = 0; j < priceAttributes[i].Count(); j++)
                    {
                        newProductDetail.prodId = newProduct.prodId;
                        switch (j)
                        {
                            case 0:
                                newProductDetail.weightAmount = Convert.ToInt32(priceAttributes[i][j]);
                                break;
                            case 1:
                                newProductDetail.weightUnit = priceAttributes[i][j];
                                break;
                            case 2:
                                newProductDetail.price = Convert.ToInt32(priceAttributes[i][j]);
                                break;
                            default:
                                break;
                        }
                    }
                    Database.Add(newProductDetail);
                    Database.SaveChanges();
                    Debug.WriteLine("CHANGES TO PRODUCT DETAIL TABLE SAVED");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("PRODUCT DETAIL ERROR: " + ex);
                }
            }



            //List of prices
            var discountArray = data["discount"].ToArray();
            List<String[]> discountAttributes = new List<String[]>();
            Debug.WriteLine("PRICE DATA " + discountArray[0] + " AND " + discountArray[0][0]);

            ////For each discount input in discount price
            for (int i = 0; i < discountArray.Length; i++)
            {
                try
                {
                    discountAttributes.Add(discountArray[i].Split(","));
                    for (int j = 0; j < discountAttributes[i].Count(); j++)
                    {
                        switch (j)
                        {
                            case 0:
                                newDiscountRate.discName = discountAttributes[i][j];
                                break;
                            case 1:
                                newDiscountRate.discRate = Convert.ToInt32(discountAttributes[i][j]);
                                break;
                            default:
                                break;
                        }
                    }
                    Database.Add(newDiscountRate);
                    Database.SaveChanges();
                    newProductDiscountRate.discountId = newDiscountRate.discId;
                    newProductDiscountRate.prodId = newProduct.prodId;
                    Database.Add(newProductDiscountRate);
                    Database.SaveChanges();
                    Debug.WriteLine("CHANGES TO DISCOUNT RATE TABLE SAVED");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("DISCOUNT RATE ERROR: " + ex);
                }
            }
            return Ok(new
            {
                message = "Saved Brand Record"
            });
        }

        // PUT api/<controller>/5
        [HttpPut("UpdateProduct/{id}")]
        public IActionResult Put(int id, [FromForm]IFormCollection data)
        {
            string customMessage = "";
            string fileName = "";

            //create Product object
            Product newProduct = new Product()
            {
                productDetails = new List<productDetail>(),
                productDiscountRates = new List<productDiscountRate>()
            };

            //Create a new productDetail and productDiscountRate object
            productDetail foundOneProductDetail = new productDetail();
            productDiscountRate foundOneProductDiscountRate = new productDiscountRate();

            //Cloudinary account
            //Account account = new Account(
            //    "singapore-polytechnic-csc-assignment-ca1",
            //    "475859446543313",
            //    "CQfmX8pn-pNZOFijjVn-nIhqKqs");
            //Cloudinary cloudinary = new Cloudinary(account);

            discountRate foundOneDiscountRate = new discountRate();

            try
            {
                var foundOneProd = Database.Products
                    .SingleOrDefault(oneProd => oneProd.prodId == id);

                //    //Required Fields
                foundOneProd.prodName = data["prodName"];
            foundOneProd.prodCode = data["prodCode"];
            foundOneProd.prodImgUrl = null;
            foundOneProd.brandId = Convert.ToInt32(data["brandId"]);
            foundOneProd.createdAt = DateTime.Now;

            //    //Get File Path
            //    if (fileInput != null)
            //    {
            //        foreach (var file in fileInput)
            //        {
            //            fileName = Path.GetFullPath(file.FileName);
            //        }
            //    }

            //    //Image
            //    if (fileName != null)
            //    {
            //        var uploadParams = new ImageUploadParams()
            //        {
            //            File = new FileDescription(fileName)
            //        };
            //        var uploadResult = cloudinary.Upload(uploadParams);
            //    }

            //Optional Fields
            foundOneProd.guaranteedAnalysis = data["GA"];
                foundOneProd.prodDesc = data["prodDesc"];
                foundOneProd.prodIngredients = data["prodIng"];
                foundOneProd.updatedBy = data["updatedBy"];
                foundOneProd.createdBy = data["createdBy"];

                if (data["published"].Count != 0)
                {
                    foundOneProd.published = Convert.ToInt32(data["published"]);
                }
                foundOneProd.updatedAt = DateTime.Now;

                //List of prices
                var priceArray = data["price"].ToArray();
                List<String[]> priceAttributes = new List<String[]>();


                //Update Database
                Database.Update(foundOneProd);

                //Save changess
                Database.SaveChanges();
            }
            catch(Exception ex)
            {
                if (ex.InnerException != null)
                {
                    if (ex.InnerException.Message.Contains("Product_prodName_UniqueConstraint") == true)
                    {
                        customMessage = "Unable to save Product record due to another record having the same name: " + data["prodName"];
                        return BadRequest(new { message = customMessage });
                    }
                    else
                    {
                        customMessage = "Unable to save Product record due to internal server errors";
                        return BadRequest(new { message = customMessage });
                    }
                }
                else
                {
                    Debug.WriteLine("THE EXCEPTION IS " + ex);
                }
            }


            ////List of prices
            //var discountArray = data["discount"].ToArray();
            //List<String[]> discountAttributes = new List<String[]>();
            //Debug.WriteLine("PRICE DATA " + discountArray[0] + " AND " + discountArray[0][0]);

            ////For each discount input in discount price
            //for (int i = 0; i < discountArray.Length; i++)
            //{
            //    try
            //    {
            //        discountAttributes.Add(discountArray[i].Split(","));
            //        for (int j = 0; j < discountAttributes[i].Count(); j++)
            //        {
            //            switch (j)
            //            {
            //                case 0:
            //                    foundOneDiscountRate.discName = discountAttributes[i][j];
            //                    break;
            //                case 1:
            //                    foundOneDiscountRate.discRate = Convert.ToInt32(discountAttributes[i][j]);
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //        Database.Update(foundOneDiscountRate);
            //        Database.SaveChanges();

            //        foundOneProductDiscountRate.discountId = foundOneDiscountRate.discId;
            //        foundOneProductDiscountRate.prodId = foundOneProductDiscountRate.prodId;

            //        Database.Update(foundOneProductDiscountRate);
            //        Database.SaveChanges();
            //        Debug.WriteLine("CHANGES TO DISCOUNT RATE TABLE SAVED");
            //    }
            //    catch (Exception ex)
            //    {
            //        Debug.WriteLine("DISCOUNT RATE ERROR: " + ex);
            //    }
        //}
            return Ok(new
            {
                message = "Updated Brand Record"
            });
        }

        // DELETE api/<controller>/5
        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            string customMessage = "";

            try
            {
                var foundOneProd = Database.Products
                    .SingleOrDefault(oneProd => oneProd.prodId == id);

                Database.Products.Remove(foundOneProd);

                Database.SaveChanges();
            }
            catch(Exception ex)
            {
                customMessage = "Unable to delete product: " + ex;
                return BadRequest(new { message = customMessage });
            }

            return Ok(new { message = "Successfully deleted product" });
        }
    }
}
