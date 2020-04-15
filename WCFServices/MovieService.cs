using Models;
using Models.Filters;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MovieService" in both code and config file together.
    public class MovieService : BaseService<MovieRepository, Movie, MovieModel, MovieFilter>, IMovieService
    {

    }
}
