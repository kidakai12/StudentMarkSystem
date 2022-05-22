using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BUS;
using DTO;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace WebForm.Pages.Shared
{
    public class QuanLyNhanVien_ThemModel : PageModel
    {
        [BindProperty]
        public NhanVienDTO nhanvien { set; get; }


        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new NhanVienBUS().Insert(new NhanVienDTO(
                nhanvien.Id_NV, 
                nhanvien.Hoten_NV, 
                nhanvien.Email_NV, 
                nhanvien.Sdt_NV, 
                nhanvien.Gioitinh_NV, 
                nhanvien.Tinh_Trang)))
            {
                HttpContext.Session.SetString("themnhanvien", "true");
                return Redirect("/Shared/QuanLyNhanVien");
            }
            HttpContext.Session.SetString("themnhanvien", "false");
            return Redirect("/Shared/QuanLyNhanVien");
        }
    }
}
