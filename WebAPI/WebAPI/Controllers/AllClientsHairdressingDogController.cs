using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllClientsHairdressingDogController : ControllerBase
    {
        private readonly AuthenticationContext _dbContext;
        public AllClientsHairdressingDogController(AuthenticationContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetAllClientsHairdressingDog")]
        //GET:/api/GetAllClientsHairdressingDog
        public async Task<ActionResult<IEnumerable<ClientHairdressingDog>>> GetAllClientsHairdressingDog()
        {
            try
            {
                var ClientHairdressing = await _dbContext.ClientHairdressingDog.FromSql("EXECUTE dbo.SP_ClientHairdressingDog").ToListAsync();

                return Ok(ClientHairdressing);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("GetOrders")]
        //GET:/api/GetOrders
        public async Task<ActionResult<IEnumerable<ClientHairdressingDogOrder>>> GetOrders(int id)
        {
            try
            {
                List<ClientHairdressingDogOrder> clientOrders = await _dbContext.ClientHairdressingDogOrder.Where(x => x.clientId == id).ToListAsync();
                return Ok(clientOrders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
