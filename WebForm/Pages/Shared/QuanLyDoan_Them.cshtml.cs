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
    public class QuanLyDoan_ThemModel : PageModel
    {
        [BindProperty]
        public DoanDuLichDTO doan { set; get; }
        public List<TourDTO> listtour { get; set; }
        public void OnGet()
        {
            listtour = new TourBUS().List().FindAll(x => x.Tinh_Trang == 1);
        }
        public IActionResult OnPostAdd()
        {
            var parsedDate1 = DateTime.ParseExact(doan.Ngaykhoihanh, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            doan.Ngaykhoihanh = parsedDate1.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var parsedDate2 = DateTime.ParseExact(doan.Ngayketthuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            doan.Ngayketthuc = parsedDate2.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Tool tool = new Tool();
            if (tool.comparedate(doan.Ngaykhoihanh, doan.Ngayketthuc) > 0 ||
                tool.comparetoday(doan.Ngaykhoihanh) < 0)
            {
                HttpContext.Session.SetString("themdoan", "false");
                return Redirect("/Shared/QuanLyDoan");
            }

            doan.Doanhthu = 0;
            if (new DoanDuLichBUS().Insert(doan))
            {
                HttpContext.Session.SetString("themdoan", "true");
                return Redirect("/Shared/QuanLyDoan");
            }
            HttpContext.Session.SetString("themdoan", "false");
            return Redirect("/Shared/QuanLyDoan");
        }
    }
}
