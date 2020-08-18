using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien.Core.Entities
{
    public class Employee : EntityBase
    {
        /*public int EmployeeID { get; set; }*/
        public Guid DepartmentID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Adrress { get; set; }
        public string Email { get; set; }
        public Department Department { get; set; }
    }
}
