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
    public class QuanLyDiaDiemModel : PageModel
    {
        [BindProperty]
        public DiaDiemDTO diadiem { set; get; }
        [BindProperty]
        public string searchtype { set; get; }
        [BindProperty]
        public string searchvalue { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(diadiem);
            HttpContext.Session.SetString("editdiadiem", str);
            return RedirectToPage("/Shared/QuanLyDiaDiem_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new DiaDiemBUS().Delete(diadiem.Id_DiaDiem))
                {
                    HttpContext.Session.SetString("xoadiadiem", "true");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoadiadiem", "false");
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
