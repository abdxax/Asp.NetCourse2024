using DatingAPIUdemy.Data;
using DatingAPIUdemy.Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAPIUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(AppDbContext _context) : ControllerBase
    {
        /*private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }*/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users=await _context.users.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user =await _context.users.FindAsync(id);
            if (user == null) return NotFound();
            return user;
        }
    }
}
