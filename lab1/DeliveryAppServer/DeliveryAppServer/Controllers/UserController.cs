using Microsoft.AspNetCore.Mvc;
using TransportCompany1;

namespace DeliveryAppServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost("~/Authentication")]
        public ActionResult<SDEK> Authentication(string login, string password)
        {
            return Ok(DataBaseManager.AuthUser(
                new User(login, password)));
        }
        [HttpPost("~/Registration")]
        public ActionResult<int> Registration(string lastName, string firstName, string patronymic, string phoneNumber, string address, string login, string password, Role role = Role.User)
        {
            return Ok(DataBaseManager.CreateUser(
                new User(lastName, firstName, patronymic, phoneNumber, address, login, password, role)));
        }
    }
}