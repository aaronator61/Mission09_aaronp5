using Microsoft.AspNetCore.Mvc;
using Mission09_aaronp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Organizing our books by category.
namespace Mission09_aaronp5.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookStoreRepository repo { get; set; }

        public TypesViewComponent (IBookStoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData.Values["category"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }
}
