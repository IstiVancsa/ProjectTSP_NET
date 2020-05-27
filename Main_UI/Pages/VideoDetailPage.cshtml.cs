using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieService;

namespace Main_UI.Pages
{
    public class VideoDetailPageModel : PageModel
    {
        public MovieExtraPropertyModel[] ExtraProperties { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchText { get; set; } = "";
        public int Total => ExtraProperties.Count();
        public async Task<IActionResult> OnGetAsync(int id)
        {
            MovieServiceClient client = new MovieServiceClient(MovieServiceClient.EndpointConfiguration.NetTcpBinding_IMovieService);
            var result = await client.GetByFilterAsync(new MovieFilter { Id = id });
            if (SearchText.Length >= 1)
            {
                this.ExtraProperties = result.FirstOrDefault().MovieExtraProperties.OrderBy(x => x.PropertyName)
                    .Where(x => x.PropertyName.ToLower().Contains(SearchText) || x.PropertyValue.ToLower().Contains(SearchText))
                    .ToArray();
            }
            else
                this.ExtraProperties = result.FirstOrDefault().MovieExtraProperties.OrderBy(x => x.PropertyName).ToArray();
            await client.CloseAsync();
            return Page();
        }
    }
}
