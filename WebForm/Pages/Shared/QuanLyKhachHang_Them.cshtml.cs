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
    public class QuanLyKhachHang_ThemModel : PageModel
    {
        [BindProperty]
        public KhachDTO khachhang { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new KhachHangBUS().Insert(new KhachDTO(
                khachhang.Id_Khach, 
                khachhang.Hoten_Khach,
                khachhang.Cmnd_Khach,
                khachhang.Diachi_Khach,
                khachhang.Gioitinh_Khach,
                khachhang.Sdt_Khach,
                khachhang.Quoctich,
                khachhang.Tinh_Trang)))
            {
                HttpContext.Session.SetString("themkhachhang", "true");
                return Redirect("/Shared/QuanLyKhachHang");
            }
            HttpContext.Session.SetString("themkhachhang", "false");
            return Redirect("/Shared/QuanLyKhachHang");
        }
    }
}
