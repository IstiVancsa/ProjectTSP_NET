using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoService;

namespace Main_UI.Pages
{
    public class PhotoDetailPageModel : PageModel
    {
        public PhotoExtraPropertyModel[] ExtraProperties { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchText { get; set; } = "";
        public int Total => ExtraProperties.Count();
        public async Task<IActionResult> OnGetAsync(int id)
        {
            PhotoServiceClient client = new PhotoServiceClient(PhotoServiceClient.EndpointConfiguration.NetTcpBinding_IPhotoService);
            var result = await client.GetByFilterAsync(new PhotoFilter { Id = id });
            if (SearchText.Length >= 1)
            {
                this.ExtraProperties = result.FirstOrDefault().PhotoExtraProperties.OrderBy(x => x.PropertyName)
                    .Where(x => x.PropertyValue.ToLower().Contains(SearchText) || x.PropertyName.ToLower().Contains(SearchText))
                    .ToArray();
            }
            else
                this.ExtraProperties = result.FirstOrDefault().PhotoExtraProperties.OrderBy(x => x.PropertyName).ToArray();
            await client.CloseAsync();
            return Page();
        }
    }
}
