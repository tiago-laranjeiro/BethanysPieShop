﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruit pie"},
                new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy pie"},
                new Category{CategoryId=3, CategoryName="Seasonal pies", Description="Nowadays pie"}
            };
    }
}
