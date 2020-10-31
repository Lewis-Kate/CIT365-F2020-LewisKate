using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]

        public string SearchString { get; set; }

        private SelectList bookSelectList;

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList GetBookSelectList()
        {
            return bookSelectList;
        }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public void SetBookSelectList(SelectList value)
        {
            bookSelectList = value;
        }

        [BindProperty(SupportsGet = true)]

        public string BookNames { get; set; }

        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }







        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_sort" : "";
            DateSort = sortOrder == "Date" ? "date_sort" : "Date";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Scripture> scriptures = from s in _context.Scripture
                                              select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "book_sort":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderByDescending(s => s.DateAdded);
                    break;
                case "date_sort":
                    scriptures = scriptures.OrderBy(s => s.DateAdded);
                    break;
                
                default:
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
            }


            IQueryable<Scripture> scripture = from s in _context.Scripture
                                              select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scripture = scripture.Where(s => s.Note.Contains(SearchString));
            }

            //Select List
            IQueryable<string> bookList = from s in _context.Scripture
                                          orderby s.Book
                                          select s.Book;
            SetBookSelectList(new SelectList(await bookList.Distinct().ToListAsync()));
            if (!string.IsNullOrEmpty(BookNames))
            {
                scripture = scripture.Where(x => x.Book == BookNames);
            }

            Scripture = await scripture.ToListAsync();
        }
    }
}
