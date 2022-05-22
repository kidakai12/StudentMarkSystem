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
    public class QuanLyChiTietTour_ThemModel : PageModel
    {
        [BindProperty]
        public ChiTietTourDTO tour { get; set; }
        public List<DiaDiemDTO> listdiadiem { get; set; }
        public void OnGet()
        {
            listdiadiem = new DiaDiemBUS().List();
        }

        public IActionResult OnPostAdd()
        {
            string idtour = HttpContext.Session.GetString("chitiettour");
            tour.Id_Tour = idtour;
            if (new ChiTietTourBUS().Insert(tour))
            {
                HttpContext.Session.SetString("themchitiettour", "true");
                return Redirect("/Shared/QuanLyChiTietTour");
            }
            HttpContext.Session.SetString("themchitiettour", "false");
            return Redirect("/Shared/QuanLyChiTietTour");
        }
    }
}
