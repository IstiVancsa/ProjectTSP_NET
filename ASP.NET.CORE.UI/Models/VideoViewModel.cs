using MovieService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.CORE.UI.Models
{
    public class VideoViewModel
    {
        public MovieModel[] Videos { get; set; }
        public object ShowExtraProperties(MovieModel model)
        {
            //Context.Response.Redirect("/About");
            return null;
        }
    }
}
