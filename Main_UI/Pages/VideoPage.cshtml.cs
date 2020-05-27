using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieService;

namespace Main_UI.Pages
{
    public class VideoPageModel : PageModel
    {
        public MovieModel[] Videos { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchText { get; set; } = "";
        public int Total => Videos.Count();
        public async Task<IActionResult> OnGetAsync()
        {
            MovieServiceClient client = new MovieServiceClient(MovieServiceClient.EndpointConfiguration.NetTcpBinding_IMovieService);
            if (SearchText.Length >= 3)
            {
                DateTime dateSearch;
                try
                {
                    dateSearch = DateTime.Parse(SearchText);
                }
                catch
                {
                    dateSearch = new DateTime();
                }
                int idSearch;
                try
                {
                    idSearch = Convert.ToInt32(SearchText);
                }
                catch
                {
                    idSearch = 0;
                }
                this.Videos = (await client.GetAllAsync()).Where(x => x.Description.ToLower().Contains(SearchText)
                                                                    || x.DateAdded == dateSearch
                                                                    || x.Name.ToLower().Contains(SearchText)
                                                                    || x.Path.ToLower().Contains(SearchText)
                                                                    || x.PathChanged.ToString() == SearchText
                                                                    || x.Id.ToString().Contains(idSearch.ToString())).ToArray();
            }
            else
                this.Videos = await client.GetAllAsync();
            await client.CloseAsync();
            return Page();
        }
    }
}
