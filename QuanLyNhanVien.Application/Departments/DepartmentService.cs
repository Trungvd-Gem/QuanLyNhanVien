using QuanLyNhanVien.Application.Departments;
using QuanLyNhanVien.Core.Data;
using QuanLyNhanVien.Core.Entities;
using QuanLyNhanVien.Core.Repositories;
using QuanLyNhanVien.ViewModels.Common;
using QuanLyNhanVien.ViewModels.Departments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Application
{
    public class DepartmentService : IDepartmentService
    {
        /*private readonly IRepository<Core.Entities.Department> _repository;*/
        private readonly QuanLyNhanVienDbContext _context;
        public DepartmentService(/*IRepository<Core.Entities.Department> repository,*/ QuanLyNhanVienDbContext context)
        {
           /* _repository = repository;*/
            _context = context;
        }
        public async Task<int> Create(DepartmentCreateRequest request)
        {
            var department = new Department()
            {
                DepartmentName = request.DepartmentName,
                Description = request.Description
            };
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();

            return department.DepartmentID;
        }

        public Task<int> Delete(int DepartmentId)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentViewModel> GetAllDepartment(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<DepartmentViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize, int order)
        {
            throw new NotImplementedException();
        }

       

        public Task<int> Update(DepartmentUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
