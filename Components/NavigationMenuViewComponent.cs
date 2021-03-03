using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models;

namespace Assignment5.Components

    //Component for building the navigation to filter by category

{
    
    
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IBookstoreRepository repository; 
        public NavigationMenuViewComponent (IBookstoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedType = RouteData?.Values["category"];
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }


    }
}
