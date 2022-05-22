using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using BUS;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace WebForm.Pages.Pages
{
    public class QuanLyTourModel : PageModel
    {
        [BindProperty]
        public TourDTO tour { set; get; }
        [BindProperty]
        public string searchtype { set; get; }

        [BindProperty]
        public string searchvalue { set; get; }
        public void OnGet()
        {

        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(tour);
            HttpContext.Session.SetString("edittour", str);
            return RedirectToPage("/Shared/QuanLyTour_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new TourBUS().Delete(tour.Id_Tour))
                {
                    HttpContext.Session.SetString("xoatour", "true");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoatour", "false");
                return Page();
            }
            return Page();
        }
        public IActionResult OnPostDetail()
        {
            HttpContext.Session.SetString("chitiettour", tour.Id_Tour);
            return RedirectToPage("/Shared/QuanLyChiTietTour");
        }
        public IActionResult OnPostSearch()
        {
            HttpContext.Session.SetString("searchtype", searchtype);
            HttpContext.Session.SetString("search", searchvalue);
            return Page();
        }
    }
}
