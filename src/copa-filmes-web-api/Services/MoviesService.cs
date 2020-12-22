using CopaFilmes.WebApi.Interfaces;
using CopaFilmes.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.WebApi.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;
        public MoviesService(IMoviesRepository moviesReository)
        {
            _moviesRepository = moviesReository;
        }

        public IList<Movies> GetMovies()
        {
            return _moviesRepository.GetAllMovies();
        }
        public IList<Movies> GetResult(IList<Movies> movies)
        {
            var filmes = movies.OrderBy(o => o.Titulo).ToList();

            for (int i = 0; i < 2; i++)
            {
                filmes = GenerateResult(filmes);
            }

            return filmes.OrderByDescending(x => x.Nota).ThenBy(x=> x.Titulo).ToList();
        }

        #region Privates
        private List<Movies> GenerateResult(List<Movies> filmes)
        {
            var listFilmes = new List<Movies>();

            var count = filmes.Count / 2;

            for (int i = 0; i < count; i++)
            {
                var first = filmes.First();
                var last = filmes.Last();

                var result = first.Nota > last.Nota || first.Nota == last.Nota ? first : last;

                listFilmes.Add(result);

                filmes.Remove(first);
                filmes.Remove(last);
            }

            return listFilmes;
        }
    }

    #endregion
}
