using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BUS;
using DTO;
using Microsoft.AspNetCore.Http;
namespace WebForm.Pages.Shared
{
    public class QuanLyChiTietDoan_ThemModel : PageModel
    {
        [BindProperty]
        public string idkhach
        {
            set;get;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPostAdd()
        {
            string gia = HttpContext.Session.GetString("chitietdoan-giatour");
            string iddoan = HttpContext.Session.GetString("chitietdoan");
            try
            {
                if (new ChiTietDoanBUS().Insert(new ChiTietDoanDTO(iddoan, idkhach)))
                {
                    new DoanDuLichBUS().UpdateDoanhThu(iddoan, -long.Parse(gia));
                    HttpContext.Session.SetString("themchitietdoan", "true");
                    return Redirect("/Shared/QuanLyChiTietDoan");
                }
            }
            catch (Exception e)
            {
                HttpContext.Session.SetString("themchitietdoan", "false");
                return Redirect("/Shared/QuanLyChiTietDoan");
            }
            HttpContext.Session.SetString("themchitietdoan", "false");
            return Redirect("/Shared/QuanLyChiTietDoan");
        }
    }
}
