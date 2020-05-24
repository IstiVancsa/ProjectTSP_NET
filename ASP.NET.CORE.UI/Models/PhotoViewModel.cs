using Microsoft.AspNetCore.Http;
using PhotoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.CORE.UI.Models
{
    public class PhotoViewModel
    {
        public PhotoModel[] Photos { get; set; }
        public object ShowExtraProperties(PhotoModel model)
        {
            //Context.Response.Redirect("/About");
            return HttpResponse.Redirect("/PhotoDetail");
        }
    }
}
