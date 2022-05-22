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
    public class QuanLyDoanModel : PageModel
    {
        [BindProperty]
        public DoanDuLichDTO doan { set; get; }

        [BindProperty]
        public string searchtype { set; get; }

        [BindProperty]
        public string searchvalue { set; get; }
        [BindProperty]
        public string dt1 { set; get; }
        [BindProperty]
        public string dt2 { set; get; }
        public void OnGet()
        {

        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(doan);
            HttpContext.Session.SetString("editdoan", str);
            return RedirectToPage("/Shared/QuanLyDoan_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new DoanDuLichBUS().Delete(doan.Id_Doan))
                {
                    HttpContext.Session.SetString("xoadoan", "true");
                    return Page();
                }
            }
            catch (Exception e)
            {
                HttpContext.Session.SetString("xoadoan", "false");
                return Page();
            }
            return Page();
        }
        public IActionResult OnPostDetail()
        {
            string gia = new DoanDuLichBUS().getGiaTour(doan.Ngaykhoihanh, doan.Id_Tour);
            if (gia != null)
            {
                HttpContext.Session.SetString("chitietdoan-giatour", gia);
                HttpContext.Session.SetString("chitietdoan", doan.Id_Doan);
                return RedirectToPage("/Shared/QuanLyChiTietDoan");
            }
            HttpContext.Session.SetString("xemchitietdoan", "false");
            return RedirectToPage("/Shared/QuanLyDoan");
        }

        public IActionResult OnPostSearch()
        {
            HttpContext.Session.SetString("searchtype", searchtype);
            HttpContext.Session.SetString("search", searchvalue);
            return Page();
        }

        public IActionResult OnPostSearchdate()
        {
            var parsedDate1 = DateTime.ParseExact(dt1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            dt1 = parsedDate1.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var parsedDate2 = DateTime.ParseExact(dt2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            dt2 = parsedDate2.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            HttpContext.Session.SetString("searchtype", "ngay");
            HttpContext.Session.SetString("dt1", dt1);
            HttpContext.Session.SetString("dt2", dt2);
            return Page();
        }
    }
}
