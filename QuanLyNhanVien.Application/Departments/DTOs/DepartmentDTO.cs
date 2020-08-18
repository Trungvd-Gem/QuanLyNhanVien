using QuanLyNhanVien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien.Application.Departments.DTOs
{
    public class DepartmentDTO: EntityBase
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        public static DepartmentDTO FromEntity(Core.Entities.Department entity)
        {
            return new DepartmentDTO
            {
                Id = entity.Id,
                CreatedDate = entity.CreatedDate,
                UpdatedDate = entity.UpdatedDate,
                DepartmentName = entity.DepartmentName,
                Description = entity.Description
            };
        }

        public Core.Entities.Department ToEntity()
        {
            return new Core.Entities.Department
            {
                Id = Id,
                CreatedDate = CreatedDate,
                UpdatedDate = UpdatedDate,
                DepartmentName = DepartmentName,
                Description = Description
            };
        }
    }
}
