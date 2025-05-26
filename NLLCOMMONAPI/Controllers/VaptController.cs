using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLLCOMMONAPI.Models;

namespace NLLCOMMONAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class VaptController : ControllerBase
    {
        private readonly ILogger<VaptController> _logger;
        private readonly Mdmdbcontext _context;

        public VaptController(ILogger<VaptController> logger, Mdmdbcontext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// API to save system log
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>

        [HttpPost("saveSystemlog")]
        public async Task<IActionResult> SaveEmployee(SystemlogModel data)
        {
            var settings = await _context.SaveSystemLog(data);
            return Ok(settings);

        }

        /// <summary>
        /// API to get settings
        /// </summary>
        /// <returns></returns>

        [HttpGet("GetSettings")]
        public async Task<IActionResult> GetSettings()
        {
           var settings = await _context.GetSettingsAsync();
            return Ok(settings);
        }

       


    }
}
