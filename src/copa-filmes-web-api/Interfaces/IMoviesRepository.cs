using CopaFilmes.WebApi.Models;
using System.Collections.Generic;

namespace CopaFilmes.WebApi.Interfaces
{
    public interface IMoviesRepository 
    {
        IList<Movies> GetAllMovies();
        
    }
}
