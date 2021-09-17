﻿using EcommerceW8.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace EcommerceW8.Data
{
    public class Seeder
    {
        public static async Task SeedData(ECommerceW8DbContext dbcontext)
        {
            try
            {
                dbcontext.Database.EnsureCreated();
                if (!dbcontext.Category.Any())
                {
                    var dirDb = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var data = File.ReadAllText(dirDb + @"/Category.json");
                    var listOfCategories = JsonConvert.DeserializeObject<List<Category>>(data);

                    await dbcontext.Category.AddRangeAsync(listOfCategories);

                    await dbcontext.SaveChangesAsync();
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error with seeding", exception);

            }
        }
    }
}

