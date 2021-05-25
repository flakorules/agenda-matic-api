namespace AgendaMatic.api.Controllers
{
    using AgendaMatic.api.Models;
    using AgendaMatic.api.Request;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="UsersController" />.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Defines the _context.
        /// </summary>
        private readonly AgendaMaticContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="context">The context<see cref="AgendaMaticContext"/>.</param>
        public UsersController(AgendaMaticContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The Login.
        /// </summary>
        /// <param name="authRequest">The authRequest<see cref="AuthRequest"/>.</param>
        /// <returns>The <see cref="IActionResult"/>.</returns>
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
