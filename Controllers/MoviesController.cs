﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = getMovies();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = getMovies().SingleOrDefault(c => c.Id == id);
            return View(movie);
        }
        private List<Movie> getMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Name="Shrek"},
                new Movie {Id=2, Name="Cars"}
            };
        }
    }
}