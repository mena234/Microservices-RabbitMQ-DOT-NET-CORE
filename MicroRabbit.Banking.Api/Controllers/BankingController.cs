using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/Bank")]
    public class BankingController : Controller
    {
        private readonly IAccountServices _accountServices;

        public BankingController(IAccountServices accountServices) =>
            _accountServices = accountServices;


        [HttpGet]
        public ActionResult GetAccounts() => Ok(_accountServices.GetAccounts());

        [HttpPost]
        public IActionResult Post(AccountTransfer accountTransfer)
        {
            _accountServices.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
