using Microsoft.AspNetCore.Mvc;
using TransportCompany1;
using TransportCompany2;

namespace DeliveryAppServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportCompanyController : Controller
    {
        private readonly ILogger<TransportCompanyController> _logger;

        public TransportCompanyController(ILogger<TransportCompanyController> logger)
        {
            _logger = logger;
        }

        [HttpGet("~/GetInfoSDEK")]
        public ActionResult<SDEK> GetInfoSDEK()
        {
            return Ok(DataBaseManager.GetInfoSDEK(new SDEK()));
        }
       
        [HttpGet("~/GetInfoUralTransit")]
        public ActionResult<UralTransit> GetInfoUralTransit()
        {
            return Ok(DataBaseManager.GetInfoUralTransit(new UralTransit()));
        }

        [HttpGet("~/CreateOrderSDEK")]
        public ActionResult<Order> CreateOrderSDEK(int userId, string whereFrom, bool fromDoor, string whereTo, bool toDoor, decimal weight, decimal volume, decimal price)
        {
            return Ok(DataBaseManager.CreateOrderSDEK(new Order(userId, whereFrom, fromDoor, whereTo, toDoor, weight, volume, price, DateTime.Now)));
        }
        [HttpGet("~/CreateOrderUralTransit")]
        public ActionResult<Order> CreateOrderUralTransit(int userId, string whereFrom, bool fromDoor, string whereTo, bool toDoor, decimal weight, decimal volume, decimal price)
        {
            return Ok(DataBaseManager.CreateOrderUralTransit(new Order(userId, whereFrom, fromDoor, whereTo, toDoor, weight, volume, price, DateTime.Now)));
        }
        [HttpPost("~/GetOrdersSDEK")]
        public ActionResult<Order> GetOrdersSDEK(bool isAdmin)
        {
            return Ok(DataBaseManager.GetOrdersSDEK(isAdmin));
        }
        [HttpPost("~/GetOrdersUralTransit")]
        public ActionResult<Order> GetOrdersUralTransit(bool isAdmin)
        {
            return Ok(DataBaseManager.GetOrdersUralTransit(isAdmin));
        }
    }
}
