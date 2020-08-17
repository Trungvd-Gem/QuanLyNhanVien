using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien.ViewModels.Departments
{
    public class DepartmentUpdateRequest
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
    }
}
