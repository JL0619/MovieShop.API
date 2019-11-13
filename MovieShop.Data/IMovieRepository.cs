using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Entity;



namespace MovieShop.Data
{
    public interface IMovieRepository :IRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetHighestGrossingMovie();
    }
}
