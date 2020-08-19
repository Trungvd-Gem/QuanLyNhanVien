using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuanLyNhanVien.Application.Departments;
using QuanLyNhanVien.Application.Departments.DTOs;
using QuanLyNhanVien.Core.Data;
using QuanLyNhanVien.Core.Entities;
using QuanLyNhanVien.Core.Repositories;
using QuanLyNhanVien.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Application
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository<Core.Entities.Department> _repository;
        private readonly ILogger<DepartmentService> _logger;
        private readonly QuanLyNhanVienDbContext _context;
        public DepartmentService(IRepository<Core.Entities.Department> repository,
            ILogger<DepartmentService> logger,
            QuanLyNhanVienDbContext context)
        {
            _repository = repository;
            _logger = logger;
            _context = context;
        }

        public async Task<DepartmentDTO> AddDepartmentAsync(DepartmentDTO department)
        {
            var entity = department.ToEntity();
            await _repository.AddAsync(entity);

            _logger.LogInformation("Created {@department}", entity);

            return DepartmentDTO.FromEntity(entity);
        }

        public async Task DeleteDepartmentAsync(Guid id)
        {
            var current = await _repository.GetAsync(id);
            await _repository.DeleteAsync(current);

            _logger.LogInformation("Deleted {@current}", current);
        }

        public async Task<IEnumerable<DepartmentDTO>> GetAllAsync()
        {
            var allDepartment = await _repository.GetAllAsync();
            return allDepartment.Select(DepartmentDTO.FromEntity);
        }

        
        public async Task<PagedResult<DepartmentViewModel>> GetAllPaging(int pageIndex, int pageSize)
        {
            var department = _context.Departments.Select(x =>
              new DepartmentViewModel()
              {
                  DepartmentName = x.DepartmentName,
                  Description = x.Description

              });
            int totalRow = await department.CountAsync();


            var data = department.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();


            var page = new PagedResult<DepartmentViewModel>()
            {
                TotalRecord = totalRow,
                Items = await data
            };
            return page;
        }

        

        public async Task<PagedResult<DepartmentViewModel>> GetSearchPaging(string keyword, int pageIndex, int pageSize)
        {
            var department = _context.Departments.Select(x =>
             new DepartmentViewModel()
             {
                 DepartmentName = x.DepartmentName,
                 Description = x.Description

             });

            if (!string.IsNullOrEmpty(keyword))
            {
                department = department.Where(p => p.DepartmentName.Contains(keyword) || p.Description.Contains(keyword) );
            }
            int totalRow = await department.CountAsync();


            var data = department.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
                

            var page = new PagedResult<DepartmentViewModel>()
            {
                TotalRecord = totalRow,
                Items = await data
            };
            return page;
        }

        public async Task UpdateDepartmentAsync(DepartmentDTO department)
        {
            
            _logger.LogInformation("Updating {@department}", department);

            await _repository.UpdateAsync(department.ToEntity());
        }

        
    }
}
