using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MYWEB_MVC_.Models;

namespace MYWEB_MVC_.Controllers
{
    public class HomeController : Controller

    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var staticLessons = new Lesson[]
            {
                 new Lesson
    {
        Title = "Serve localized content",
        Slug = "serve-localized-content",
        Modules = new Module[]
        {
            new Module
            {
                Title = "Serve localized content > fetching",
                Copy = "If you have configured different locales within your content model, you can fetch that localized content:"
            },
            new Module
            {
                Title = "Serve localized content > fetch code",
                Copy = "var queryBuilder = QueryBuilder<dynamic>.New.LocaleIs(\"de-DE\");\nvar entries = await client.GetEntriesAsync(queryBuilder);\nConsole.WriteLine(entries.ToString());"
            },
            new Module
            {
                Title = "Serve localized content > code success",
                Copy = "Switch the language of this text from English to German by going to `Locale: U.S. English` in the top menu bar and selecting `German`."
            }
        }
    },
    new Lesson
    {
        Title = "Content management",
        Slug = "content-management",
        Modules = new Module[]
        {
            new Module
            {
                Title = "Content management > copy 1",
                Copy = "A basic Contentful setup consists of a client application reading content, this example app for instance, and another application that is writing content, like the Contentful web app. The client application is reading content by connecting to the Content Delivery API. The Contentful web app, on the other hand, is writing content by connecting to the Content Mangement API.\n\nThe Contentful web app is a single page application created by Contentful and assists with common content management tasks."
            },
            new Module
            {
                Title = "Content management > copy 2",
                Copy = "As mentioned, the Contentful web app is a client that uses the Content Management API. Therefore, you could replicate the functionality that the Contentful web app provides by making an API call. This is a powerful aspect of an API-first design because it helps you to connect Contentful to third-party systems."
                    }
                 }
                }
           };
            
            ViewBag.Lession = staticLessons;
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
