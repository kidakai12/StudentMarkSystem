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
    public class QuanLyTour_SuaModel : PageModel
    {
        [BindProperty]
        public TourDTO tour { get; set; }
        [BindProperty]
        public string loai { get; set; }
        public List<LoaiTourDTO> listloai { get; set; }
        public void OnGet()
        {
            listloai = new LoaiTourBUS().List();
            var str = HttpContext.Session.GetString("edittour");
            var obj = JsonConvert.DeserializeObject<TourDTO>(str);
            loai = obj.Id_Loai;
        }

        public IActionResult OnPostEdit()
        {
            tour.Id_Loai = loai;
            tour.Tinh_Trang = 1;
            if (new TourBUS().Update(tour))
            {
                HttpContext.Session.SetString("suatour", "true");
                return Redirect("/Shared/QuanLyTour");
            }
            HttpContext.Session.SetString("suatour", "false");
            return Page();
        }
    }
}
