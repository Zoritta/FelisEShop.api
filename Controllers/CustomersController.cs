using Microsoft.AspNetCore.Mvc;

namespace FelisEShop.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController: ControllerBase
    {
        public CustomersController(CustomerContext context)
        {
            
        }
    }
}