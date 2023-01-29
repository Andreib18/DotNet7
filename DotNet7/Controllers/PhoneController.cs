using DotNet7.Models;
using DotNet7.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneService _phoneService;

        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }
        [HttpGet]
        public async Task<ActionResult<Phone>> GetAllPhones()
        {
            return  Ok(_phoneService.GetAllPhones());
        }
        [HttpGet("id")]
        public async Task<ActionResult<Phone>> GetSinglePhone(int id)
        {
            var result = _phoneService.GetSinglePhone(id);
            if (result == null)
            return NotFound("Phone not found");
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<Phone>>AddPhone(Phone phone)
        {
            var result =_phoneService.AddPhone(phone);
            return Ok(result);
        }
        [HttpPut("id")]
        public async Task<ActionResult<Phone>>UpdatePhone(int id,Phone request)
        {
            var result =_phoneService.UpdatePhone(id, request);
            if (result == null) return NotFound("Phone was not found");
                    return Ok(result);
        }
        [HttpDelete("id")]
        public async Task<ActionResult<Phone>>DeletePhone(int id)
        {
            var result =_phoneService?.DeletePhone(id);
            return Ok(result);
        }
    }
}
