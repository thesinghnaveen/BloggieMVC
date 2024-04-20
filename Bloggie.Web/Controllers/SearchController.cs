using Bloggie.Web.Models.Domain;
using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{       public class SearchController : Controller
        {
            private readonly IBlogPostRepository _blogPostRepository;

            public SearchController(IBlogPostRepository blogPostRepository)
            {
                _blogPostRepository = blogPostRepository;
            }
        
        public IActionResult SearchBox()
        {
            return PartialView("_SearchBoxPartial");
        }


        [HttpGet]
            public async Task<IActionResult> Search(string query)
            {
                // Ensure query is not null or empty
                if (string.IsNullOrWhiteSpace(query))
                {
                    // Handle empty query if needed
                  return View("SearchResults", new List<BlogPost>());
                }

                // Perform search using the repository
                var searchResults = await _blogPostRepository.SearchAsync(query);

                return View("SearchResults", searchResults);
            }
        }
}