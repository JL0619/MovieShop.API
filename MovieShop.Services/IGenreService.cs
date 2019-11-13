using MovieShop.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllGenre();
        Task<IEnumerable<Movie>> GetMoviesByGenre(int id);
    }
}
