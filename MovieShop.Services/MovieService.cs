﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Entity;
using MovieShop.Data;


namespace MovieShop.Services
{
    public class MovieService: IMovieService
    {
        private IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> GetHighestGrossingMovie()
        {
            return await _movieRepository.GetHighestGrossingMovie();
        }
    }
}
