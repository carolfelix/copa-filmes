using CopaFilmes.WebApi.Models;
using System.Collections.Generic;

namespace CopaFilmes.WebApi.Interfaces
{
    public interface IMoviesService
    {
        IList<Movies> GetResult(IList<Movies> movies);
        IList<Movies> GetMovies();

    }
}
