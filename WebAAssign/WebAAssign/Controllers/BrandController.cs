﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAAssign.Controllers
{
    public class BrandController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult AddBrand()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult BrandList()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult UpdateBrand()
        {
            return View();
        }
    }
}
