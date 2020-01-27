using CineApi.Persistence.Contexts;

namespace CineApi.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly CineContext _context;
        public BaseRepository(CineContext context)
        {
            _context = context;
        }
    }
}