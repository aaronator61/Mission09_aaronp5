using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Our two models that will be pulled in later.
namespace Mission09_aaronp5.Models.BooksViewModels
{
    public class BooksViewModel
    {

        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
