using LavisAcademy.Models;
using LavisAcademy.Service;
using LavisAcademy.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LavisAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodsController : ControllerBase
    {
        IPeriodService _periodService;
        public PeriodsController(IPeriodService periodService)
        {
            _periodService = periodService;
        }

        [HttpPost("add")]
        public IActionResult Add(Period period)
        {
            var result = _periodService.Add(period);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(Period period)
        {
            var result = _periodService.Delete(period);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update(Period period)
        {
            var result = _periodService.Update(period);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _periodService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _periodService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
