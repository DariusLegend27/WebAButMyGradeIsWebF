using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
    public class LoginController : Controller
    {
        public ApplicationDbContext Database { get; }

        public LoginController(ApplicationDbContext databaseObjectFromServicesContainer)
        {
            Database = databaseObjectFromServicesContainer;
        }

        // GET: api/<controller>
        [HttpPost]
        public IActionResult CheckUser([FromForm]IFormCollection data)
        {
            List<SysUser> userQueryResult = new List<SysUser>();

            try
            {
                foreach(var user in userQueryResult)
                {
                    if(data["userName"] == user.userName)
                    {
                        
                    }
                    else
                    {

                    }


                    if(data["password"] == user.userPassHash)
                    {

                    }
                    else
                    {

                    }
                }
            }
            catch(Exception ex)
            {

            }

            return null;
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
