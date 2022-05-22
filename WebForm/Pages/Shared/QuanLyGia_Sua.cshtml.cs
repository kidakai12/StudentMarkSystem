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

namespace WebForm.Pages.Shared
{
    public class QuanLyGia_SuaModel : PageModel
    {
        [BindProperty]
        public GiaDTO gia { set; get; }
        [BindProperty]
        public string loai { set; get; }

        public List<TourDTO> listtour { get; set; }
        public void OnGet()
        {
            listtour = new TourBUS().List().FindAll(x => x.Tinh_Trang == 1);
            var str = HttpContext.Session.GetString("editgia");
            var obj = JsonConvert.DeserializeObject<GiaDTO>(str);
            loai = obj.Id_Tour;
        }
        public IActionResult OnPostEdit()
        {
            var parsedDate1 = DateTime.ParseExact(gia.Thoigianbatdau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            gia.Thoigianbatdau = parsedDate1.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var parsedDate2 = DateTime.ParseExact(gia.Thoigianketthuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            gia.Thoigianketthuc = parsedDate2.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Tool tool = new Tool();
            if (tool.comparedate(gia.Thoigianbatdau, gia.Thoigianketthuc) > 0 ||
                tool.comparetoday(gia.Thoigianbatdau) < 0)
            {
                HttpContext.Session.SetString("suagiatour", "false");
                return Redirect("/Shared/QuanLyGia");
            }
            gia.Id_Tour = loai;
            if (new GiaBUS().Update(gia))
            {
                HttpContext.Session.SetString("suagiatour", "true");
                return Redirect("/Shared/QuanLyGia");
            }
            HttpContext.Session.SetString("suagiatour", "false");
            return Redirect("/Shared/QuanLyGia");
        }
    }
}
