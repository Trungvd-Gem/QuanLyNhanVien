using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien.Core.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Adrress { get; set; }
        public string Email { get; set; }
        public Department Department { get; set; }
    }
}
