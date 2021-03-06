﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController (SellerService sellerservice)
        {
            _sellerService = sellerservice;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
