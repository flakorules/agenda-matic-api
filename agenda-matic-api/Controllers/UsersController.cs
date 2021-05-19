using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgendaMatic.api.Models;
using AgendaMatic.api.Request;

namespace AgendaMatic.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AgendaMaticContext _context;

        public UsersController(AgendaMaticContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(AuthRequest authRequest)
        {
            var foundUser = _context.Users.FirstOrDefault(o => o.Email == authRequest.Email && o.Password == authRequest.Password);
            
            if (foundUser == null)
            {
                return NotFound(new { message = "Username or password is incorrect" });
            }
            return Ok(new { UserId = foundUser.Id, Email = foundUser.Email });
        }
    }
}
