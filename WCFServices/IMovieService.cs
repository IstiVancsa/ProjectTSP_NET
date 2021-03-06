﻿using Models;
using Models.Filters;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMovieService" in both code and config file together.
    [ServiceContract]
    public interface IMovieService : IBaseService<MovieModel, MovieFilter, Movie>
    {
    }
}
