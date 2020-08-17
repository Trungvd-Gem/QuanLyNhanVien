using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVien.Application.Departments;
using QuanLyNhanVien.ViewModels.Departments;

namespace QuanLyNhanVien.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] DepartmentCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _departmentService.Create(request);
            if (result <= 0)
                return BadRequest(result);

            return Ok(result);
        }

    }
}
