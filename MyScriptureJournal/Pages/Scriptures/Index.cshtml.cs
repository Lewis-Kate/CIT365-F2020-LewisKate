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
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        [BindProperty(SupportsGet = true)]
        public SelectList BookSelectList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookNames { get; set; }







        public async Task OnGetAsync()
        {
            IQueryable<Scripture> scriptures = from s in _context.Scripture
                                                 orderby s.DateAdded descending
                                                 select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchString));
            }

            //Select List
            IQueryable<string> bookList = from s in _context.Scripture
                                          orderby s.Book
                                          select s.Book;
            BookSelectList = new SelectList(await bookList.Distinct().ToListAsync());
            if (!string.IsNullOrEmpty(BookNames))
            {
                scriptures = scriptures.Where(x => x.Book == BookNames);
            }

            Scripture = await scriptures.ToListAsync();
        }
    }
}
