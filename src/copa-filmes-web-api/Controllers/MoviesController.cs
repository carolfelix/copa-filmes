using AutoMapper;
using CopaFilmes.WebApi.Interfaces;
using CopaFilmes.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;
        private readonly IMapper _mapper;

        public MoviesController(IMoviesService moviesService, IMapper mapper)
        {
            _moviesService = moviesService;
            _mapper = mapper;
        }

        [HttpGet("get-movies")]
        public ActionResult GetAll()
        {
            return Ok(_mapper.Map<List<Movies>>(_moviesService.GetMovies()));
        }

        [HttpPost("result")]
        public ActionResult GetResult(List<MoviesViewModel> filmes)
        {
            return Ok(_moviesService.GetResult(_mapper.Map<List<Movies>>(filmes)));
        }
    }
}
