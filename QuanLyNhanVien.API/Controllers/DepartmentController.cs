using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVien.Application.Departments;
using QuanLyNhanVien.Application.Departments.DTOs;


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

        [HttpGet("department-search")]
        public async Task<IActionResult> SearchDepartment([FromQuery] string keyword, int pageIndex, int pageSize)
        {
            var dataDepartment = await _departmentService.GetSearchPaging(keyword, pageIndex, pageSize);
            return Ok(dataDepartment);
        }

        [HttpGet("{department}")]
        public async Task<IActionResult> GetAllPaging([FromQuery]  int pageIndex, int pageSize )
        {
            var result = await _departmentService.GetAllPaging(pageIndex, pageSize);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _departmentService.GetAllAsync();
            return Ok(result);
        }

       
        [HttpPost]
        public async Task<IActionResult> PostAsync(DepartmentDTO model)
        {
            await _departmentService.AddDepartmentAsync(model);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromQuery] DepartmentDTO model)
        {
            await _departmentService.UpdateDepartmentAsync(model);
            return Ok();
        }
       
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _departmentService.DeleteDepartmentAsync(id);
            return Ok();
        }

    }
}
