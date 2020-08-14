using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien.Core.Entities
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
