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
    public class QuanLyChiTietDoanModel : PageModel
    {
        [BindProperty]
        public ChiTietDoanDTO chitiet { set; get; }

        [BindProperty]
        public ChiPhiDTO chiphi { set; get; }
        public void OnGet()
        {
        }

        public IActionResult OnPostDelete()
        {
            string gia = HttpContext.Session.GetString("chitietdoan-giatour");
            if (new ChiTietDoanBUS().Delete(chitiet.Id_Doan, chitiet.Id_Khach))
            {
                new DoanDuLichBUS().UpdateDoanhThu(chitiet.Id_Doan, long.Parse(gia));
                HttpContext.Session.SetString("xoachitietdoan", "thanhcong");
                return Redirect("/Shared/QuanLyChiTietDoan");
            }
            HttpContext.Session.SetString("xoachitietdoan", "thatbai");
            return Page();
        }

        public IActionResult OnPostDelete2()
        {
            if (new ChiPhiBUS().Delete(chiphi.Id_LoaiChiPhi, chiphi.Id_Doan))
            {
                new DoanDuLichBUS().UpdateDoanhThu(chiphi.Id_Doan, chiphi.Gia);
                HttpContext.Session.SetString("xoachiphi", "thanhcong");
                return Redirect("/Shared/QuanLyChiTietDoan");
            }
            HttpContext.Session.SetString("xoachiphi", "thatbai");
            return Page();
        }

        public IActionResult OnPostEdit2()
        {
            string str = JsonConvert.SerializeObject(chiphi);
            HttpContext.Session.SetString("editchiphidoan", str);
            return RedirectToPage("/Shared/QuanLyChiPhi_Sua");
        }
    }
}
