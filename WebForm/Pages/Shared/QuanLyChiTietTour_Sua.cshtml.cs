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
    public class QuanLyChiTietTour_SuaModel : PageModel
    {
        [BindProperty]
        public ChiTietTourDTO tour { get; set; }

        [BindProperty]
        public string diadiem { get; set; }

        public List<DiaDiemDTO> listdiadiem { get; set; }
        public void OnGet()
        {
            listdiadiem = new DiaDiemBUS().List();
            var str = HttpContext.Session.GetString("editchitiettour");
            var obj = JsonConvert.DeserializeObject<ChiTietTourDTO>(str);
            diadiem = obj.Id_DiaDiem;
        }

        public IActionResult OnPostEdit()
        {
            var str = HttpContext.Session.GetString("editchitiettour");
            var obj = JsonConvert.DeserializeObject<ChiTietTourDTO>(str);
            tour.Id_Tour = obj.Id_Tour;
            string tmp = tour.Id_DiaDiem;
            tour.Id_DiaDiem = diadiem;
            if (new ChiTietTourBUS().Update(tour,tmp))
            {
                HttpContext.Session.SetString("suachitiettour", "true");
                return Redirect("/Shared/QuanLyChiTietTour");
            }
            HttpContext.Session.SetString("suachitiettour", "false");
            return Redirect("/Shared/QuanLyChiTietTour");
        }
    }
}
