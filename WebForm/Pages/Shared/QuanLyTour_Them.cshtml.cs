using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BUS;
using DTO;
using Microsoft.AspNetCore.Http;
namespace WebForm.Pages.Shared
{
    public class QuanLyTour_ThemModel : PageModel
    {
        [BindProperty]
        public TourDTO tour { get; set; }
        public List<LoaiTourDTO> listloai { get; set; }
        public void OnGet()
        {
            listloai = new LoaiTourBUS().List();
        }

        public IActionResult OnPostAdd()
        {
            tour.Tinh_Trang = 1;
            if (new TourBUS().Insert(tour))
            {
                HttpContext.Session.SetString("themtour","true");
                return Redirect("/Shared/QuanLyTour");
            }
            HttpContext.Session.SetString("themtour", "false");
            return Redirect("/Shared/QuanLyTour");
        }
    }
}
