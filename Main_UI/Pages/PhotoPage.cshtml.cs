using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoService;

namespace Main_UI.Pages
{
    public class PhotoPageModel : PageModel
    {
        public PhotoModel[] Photos { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchText { get; set; } = "";
        public int Total => Photos.Count();
        public async Task<IActionResult> OnGetAsync()
        {
            PhotoServiceClient client = new PhotoServiceClient(PhotoServiceClient.EndpointConfiguration.NetTcpBinding_IPhotoService);
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
                this.Photos = (await client.GetAllAsync()).Where(x => x.Id.ToString().Contains(idSearch.ToString())
                                                                || x.Path.ToLower().Contains(SearchText)
                                                                || x.PathChanged.ToString().Contains(SearchText)
                                                                || x.Place.ToLower().Contains(SearchText)).ToArray();
            }
            else
                this.Photos = await client.GetAllAsync();
            await client.CloseAsync();
            return Page();
        }
    }
}
