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
    public class QuanLyPhanCongModel : PageModel
    {
        [BindProperty]
        public PhanCongDTO phancong { set; get; }
        [BindProperty]
        public string searchtype { set; get; }
        [BindProperty]
        public string searchvalue { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(phancong);
            HttpContext.Session.SetString("editphancong", str);
            return RedirectToPage("/Shared/QuanLyPhanCong_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new PhanCongBUS().Delete(phancong.Id_Doan, phancong.Id_NV))
                {
                    HttpContext.Session.SetString("xoaphancong", "true");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoaphancong", "false");
                return Page();
            }
            return Page();
        }
        public IActionResult OnPostSearch()
        {
            HttpContext.Session.SetString("searchtype", searchtype);
            HttpContext.Session.SetString("search", searchvalue);
            return Page();
        }
    }
}
