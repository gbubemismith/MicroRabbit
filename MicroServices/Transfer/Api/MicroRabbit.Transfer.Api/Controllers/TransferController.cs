using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransferLogs()
        {
            string check = null;

            if (check is not { })
            {
                //
            }

            var transfers = await _transferService.GetTransfers();

            return Ok(transfers);
        }
    }
}