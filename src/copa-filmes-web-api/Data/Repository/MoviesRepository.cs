using CopaFilmes.WebApi.Interfaces;
using CopaFilmes.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CopaFilmes.WebApi.Data.Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        public IList<Movies> GetAllMovies()
        {
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("http://copafilmes.azurewebsites.net/api/filmes").Result;

            response.EnsureSuccessStatusCode();
            var result = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<IList<Movies>>(result);
        }
    }
}
