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
    public class QuanLyGia_ThemModel : PageModel
    {
        [BindProperty]
        public GiaDTO gia { set; get; }

        [BindProperty]
        public string dt1 { set; get; }
        [BindProperty]
        public string dt2 { set; get; }

        public List<TourDTO> listtour { get; set; }
        public void OnGet()
        {
            listtour = new TourBUS().List().FindAll(x => x.Tinh_Trang == 1);
        }
        public IActionResult OnPostAdd()
        {
            var parsedDate1 = DateTime.ParseExact(dt1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            gia.Thoigianbatdau = parsedDate1.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var parsedDate2 = DateTime.ParseExact(dt2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            gia.Thoigianketthuc = parsedDate2.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Tool tool = new Tool();
            if (tool.comparedate(gia.Thoigianbatdau, gia.Thoigianketthuc) > 0 ||
                tool.comparetoday(gia.Thoigianbatdau) < 0)
            {
                HttpContext.Session.SetString("themgiatour", "false");
                return Redirect("/Shared/QuanLyGia");
            }
            if (new GiaBUS().Insert(gia))
            {
                HttpContext.Session.SetString("themgiatour","true");
                return Redirect("/Shared/QuanLyGia");
            }
            HttpContext.Session.SetString("themgiatour", "false");
            return Redirect("/Shared/QuanLyGia");
        }
    }
}
