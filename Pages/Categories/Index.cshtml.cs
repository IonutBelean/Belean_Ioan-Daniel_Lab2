using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Belean_Ioan_Daniel_Lab2.Data;
using Belean_Ioan_Daniel_Lab2.Models;
using Belean_Ioan_Daniel_Lab2.Models.ViewModels;

namespace Belean_Ioan_Daniel_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Belean_Ioan_Daniel_Lab2.Data.Belean_Ioan_Daniel_Lab2Context _context;

        public IndexModel(Belean_Ioan_Daniel_Lab2.Data.Belean_Ioan_Daniel_Lab2Context context)
        {
            _context = context;
        }

        public CategoryIndexData CategoryData { get; set; } // ViewModel pentru categorie și cărți
        public int CategoryID { get; set; } // ID-ul categoriei selectate

        public async Task OnGetAsync(int? id)
        {
            // Populăm datele pentru categorii și cărțile asociate
            CategoryData = new CategoryIndexData
            {
                Categories = await _context.Category
                    .Include(c => c.BookCategories)
                    .ThenInclude(bc => bc.Book)
                    .ThenInclude(b => b.Author)
                    .OrderBy(c => c.CategoryName)
                    .ToListAsync()
            };

            // Dacă există o categorie selectată, încărcăm cărțile acesteia
            if (id != null)
            {
                CategoryID = id.Value;
                var selectedCategory = CategoryData.Categories
                    .Where(c => c.ID == id.Value).SingleOrDefault();

                if (selectedCategory != null)
                {
                    CategoryData.Books = selectedCategory.BookCategories
                        .Select(bc => bc.Book);
                }
            }
        }
    }
}
