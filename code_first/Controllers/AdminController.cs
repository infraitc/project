using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using code_first.Interfaces;
using code_first.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace code_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IAdminRepository _adminRepository;

        public AdminController(ILogger<AdminController> logger, IAdminRepository adminRepository)
        {
            _logger = logger;
            _adminRepository = adminRepository;
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(long id)
        {
            try
            {
                var data = _adminRepository.Delete(id);
                if (data == false)
                {
                    return NotFound();
                }

                return Ok(new { status = true, message = "Delete Successful" });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed Delete: {ex}");
                return StatusCode(500, new { status = false, message = ex });
            }
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(new { status = true, message = _adminRepository.GetAll()} );
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed GetAll: {ex}");
                return StatusCode(500, new { status = false, message = ex });
            }
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(long id)
        {
            try
            {
                var data = _adminRepository.GetById(id);

                if (data == null)
                {
                    return NotFound();
                }

                return Ok(new { status = true, message = data });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed GetById: {ex}");
                return StatusCode(500, new { status = false, message = ex });
            }
        }

        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] Admin admin)
        {
            try
            {
                var data = _adminRepository.Insert(admin);
                return Ok(new { status = true, message = data });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed Insert: {ex}");
                return StatusCode(500, new { status = false, message = ex });
            }
        }

        [HttpPut("Update/{id}")]
        public IActionResult Update([FromBody] Admin admin, long id)
        {
            try
            {
                var data = _adminRepository.Update(admin, id);
                return Ok(new { status = true, message = data });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed Update: {ex}");
                return StatusCode(500, new { status = false, message = ex });
            }
        }
    }
}