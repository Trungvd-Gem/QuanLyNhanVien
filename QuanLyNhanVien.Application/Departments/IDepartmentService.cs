using QuanLyNhanVien.Application.Departments.DTOs;
using QuanLyNhanVien.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace QuanLyNhanVien.Application.Departments
{
    public interface IDepartmentService
    {
        Task<DepartmentDTO> AddDepartmentAsync(DepartmentDTO department);
        Task UpdateDepartmentAsync(DepartmentDTO department);
        Task DeleteDepartmentAsync(Guid id);
        
        Task<IEnumerable<DepartmentDTO>> GetAllAsync();

        Task<PagedResult<DepartmentViewModel>> GetSearchPaging(string keyword, int pageIndex, int pageSize);
        Task<PagedResult<DepartmentViewModel>> GetAllPaging(int pageIndex, int pageSize);

        /*Task<DepartmentDTO> GetById(Guid id);*/


    }
}
