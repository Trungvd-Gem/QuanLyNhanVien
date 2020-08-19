using QuanLyNhanVien.Application.System.Users.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.WebApp.Services.Users
{
    public interface IUserApi
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> RegisterUser(RegisterRequest request);
    }
}
