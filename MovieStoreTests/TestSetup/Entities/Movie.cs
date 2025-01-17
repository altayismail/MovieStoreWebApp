﻿using MovieStoreWebApp.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreTest.TestSetup.Entities
{
    public static class Movie
    {
        public static void AddMovie(this MovieStoreDbContext context)
        {
            context.Movies.AddRange
            (
                new MovieStoreWebApp.Entities.Movie { MovieName = "2021-2022", GenreId = 1, DirectorId = 1, Price = 32, ReleaseYear = new DateTime(2021, 02, 25) },
                new MovieStoreWebApp.Entities.Movie { MovieName = "Bal", GenreId = 2, DirectorId = 2, Price = 45, ReleaseYear = DateTime.Now.AddYears(-5) },
                new MovieStoreWebApp.Entities.Movie { MovieName = "Don't Look Up", GenreId = 3, DirectorId = 3, Price = 3, ReleaseYear = DateTime.Now.AddYears(-2) }
            );
        }
    }
}
