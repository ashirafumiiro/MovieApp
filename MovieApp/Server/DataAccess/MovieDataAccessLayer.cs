using Microsoft.EntityFrameworkCore;
using MovieApp.Server.Interfaces;
using MovieApp.Server.Models;
using MovieApp.Shared.Models;

namespace MovieApp.Server.DataAccess
{
    public class MovieDataAccessLayer : IMovie
    {
        readonly MovieDBContext _dbContext;

        public MovieDataAccessLayer(IDbContextFactory<MovieDBContext> dbContext)
        {
            _dbContext = dbContext.CreateDbContext();
        }

        public async Task<List<Genre>> GetGenre()
        {
            return await _dbContext.Genres.AsNoTracking().ToListAsync();
        }
    }
}
