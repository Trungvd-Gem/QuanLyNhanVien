using QuanLyNhanVien.ViewModels.Common;
using QuanLyNhanVien.ViewModels.Departments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyNhanVien.Application.Departments
{
    public interface IDepartmentService
    {
        Task<int> Create(DepartmentCreateRequest request);

        Task<int> Update(DepartmentUpdateRequest request);

        Task<int> Delete(int DepartmentId);

        Task<DepartmentViewModel> GetAllDepartment(int pageIndex, int pageSize);


        Task<PagedResult<DepartmentViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize, int order);


        
    }
}
