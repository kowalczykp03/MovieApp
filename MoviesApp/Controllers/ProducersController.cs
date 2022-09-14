﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producer.ToListAsync();
            return View();
        }
    }
}
