using CineApi.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CineApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Usuarios")]
    public class CineController
    {
        private readonly CineContext _context;

        public CineController(CineContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var User = await _context.User.Include(u => u.Movie).ToArrayAsync();
            return Ok(User);
        }
    }
}