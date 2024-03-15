using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TKWebAPI.Data;
using TKWebAPI.Models;

namespace TKWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectronicController : ControllerBase
    {
        private AppDbContext _appDbContext;

        public ElectronicController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetDevices()
        {
            var devices = await _appDbContext.Devices.ToListAsync();
            return Ok(devices);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDevice(int id)
        {
            var device = await _appDbContext.Devices.FindAsync(id);
            if (device == null)
            {
                return NotFound();
            }
            return Ok(device);
        }

        [HttpPost]
        public async Task<IActionResult> PostDevice([FromBody] DevicesModel device)
        {
            if (device == null)
            {
                return BadRequest();
            }
            await _appDbContext.Devices.AddAsync(device);
            await _appDbContext.SaveChangesAsync();

            return Ok();
            //return CreatedAtActionResult(StatusCodes.Status201Created);
            //return CreatedAtAction(nameof(GetDevice), device);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDevice(int id, [FromBody] DevicesModel device) 
        {
            var devInDb = await _appDbContext.Devices.FirstOrDefaultAsync(x => x.DevId == id);
            
            if (devInDb != null)
            {
                devInDb.DevCategory = device.DevCategory;
                devInDb.DevName = device.DevName;
                devInDb.DevQuantity = device.DevQuantity;
                devInDb.DevRate = device.DevRate;

                _appDbContext.Devices.Update(devInDb);
                await _appDbContext.SaveChangesAsync();
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDevice(int id)
        {
            var devInDb = await _appDbContext.Devices.FindAsync(id);
            if(devInDb != null)
            {
                _appDbContext.Devices.Remove(devInDb);
                await _appDbContext.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
