using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using BUS;
using Microsoft.AspNetCore.Http;

namespace WebForm.Pages.Shared
{
    public class QuanLyKhachHang_SuaModel : PageModel
    {
        [BindProperty]
        public KhachDTO khachhang { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new KhachHangBUS().Update(khachhang))
            {
                HttpContext.Session.SetString("suakhachhang", "true");
                return Redirect("/Shared/QuanLyKhachHang");
            }
            HttpContext.Session.SetString("suakhachhang", "false");
            return Page();
        }
    }
}
