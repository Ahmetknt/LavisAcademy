using LavisAcademy.Models;
using LavisAcademy.Service;
using LavisAcademy.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LavisAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationCoachsController : ControllerBase
    {
        IEducationCoachService _educationCoachService;

        public EducationCoachsController(IEducationCoachService educationCoachService)
        {
            _educationCoachService = educationCoachService;
        }

        [HttpPost("add")]
        public IActionResult Add(EducationCoach educationCoach)
        {
            var result = _educationCoachService.Add(educationCoach);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(EducationCoach educationCoach)
        {
            var result = _educationCoachService.Delete(educationCoach);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update(EducationCoach educationCoach)
        {
            var result = _educationCoachService.Update(educationCoach);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _educationCoachService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _educationCoachService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
