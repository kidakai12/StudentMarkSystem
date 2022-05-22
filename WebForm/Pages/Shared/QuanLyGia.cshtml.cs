using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using BUS;
using DTO;

namespace WebForm.Pages.Shared
{
    public class QuanLyGiaModel : PageModel
    {
        [BindProperty]
        public GiaDTO gia { set; get; }

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
            string str = JsonConvert.SerializeObject(gia);
            HttpContext.Session.SetString("editgia", str);
            return RedirectToPage("/Shared/QuanLyGia_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new GiaBUS().Delete(gia.Id_Gia))
                {
                    HttpContext.Session.SetString("xoagiatour", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoagiatour", "khongthanhcong");
                return Page();
            }
            HttpContext.Session.SetString("xoagiatour", "khongthanhcong");
            return Page();
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
