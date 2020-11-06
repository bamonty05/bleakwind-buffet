﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The items to display on the index page
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The categories
        /// </summary>
        [BindProperty]
        public string[] Category { get; set; }

        /// <summary>
        /// Current min calories
        /// </summary>
        [BindProperty]
        public uint? CalorieMin { get; set; }

        /// <summary>
        /// Current max calories
        /// </summary>
        [BindProperty]
        public uint? CalorieMax { get; set; }

        /// <summary>
        /// Current min price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Current max price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        public void OnGet()
        {
            Items = Menu.FullMenu();
        }

        public void OnPost()
        {
            Items = Menu.FullMenu();
            Items = Menu.Search(Items, SearchTerms);
            Items = Menu.FilterByCategory(Items, Category);
            Items = Menu.FilterByCalories(Items, CalorieMin, CalorieMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
