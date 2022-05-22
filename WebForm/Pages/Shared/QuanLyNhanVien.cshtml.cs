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
    public class QuanLyNhanVienModel : PageModel
    {
        [BindProperty]
        public NhanVienDTO nhanvien { set; get; }
        [BindProperty]
        public string searchtype { set; get; }
        [BindProperty]
        public string searchvalue { set; get; }

        public void OnGet()
        {
            
        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(nhanvien);
            HttpContext.Session.SetString("editnhanvien", str);
            return RedirectToPage("/Shared/QuanLyNhanVien_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new NhanVienBUS().Delete(nhanvien.Id_NV))
                {
                    HttpContext.Session.SetString("xoanhanvien", "true");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoanhanvien", "false");
                return Page();
            }
            return Page();
        }

        public IActionResult OnPostDetail()
        {
            HttpContext.Session.SetString("chitietnhanvien", nhanvien.Id_NV);
            return RedirectToPage("/Shared/ThongKeNhanVien");
        }
        public IActionResult OnPostSearch()
        {
            HttpContext.Session.SetString("searchtype", searchtype);
            HttpContext.Session.SetString("search", searchvalue);
            return Page();
        }
    }
}
