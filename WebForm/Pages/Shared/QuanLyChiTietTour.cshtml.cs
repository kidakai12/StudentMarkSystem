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
    public class QuanLyChiTietTourModel : PageModel
    {
        [BindProperty]
        public ChiTietTourDTO chitiet { get; set; }

        [BindProperty]
        public string khachsan { get; set; }
        [BindProperty]
        public string anuong { get; set; }
        [BindProperty]
        public string phuongtien { get; set; }
        [BindProperty]
        public string doanhso { get; set; }
        [BindProperty]
        public string sodoan { get; set; }
        [BindProperty]
        public string tong { get; set; }

        [BindProperty]
        public string search1 { get; set; }
        [BindProperty]
        public string search2 { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPostEdit()
        {
            var str = JsonConvert.SerializeObject(chitiet);
            HttpContext.Session.SetString("editchitiettour",str);
            return RedirectToPage("/Shared/QuanLyChiTietTour_Sua");
        }

        public IActionResult OnPostDelete()
        {
            try
            {
                if (new ChiTietTourBUS().Delete(chitiet.Id_Tour,chitiet.Id_DiaDiem))
                {
                    HttpContext.Session.SetString("xoachitiettour", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoachitiettour", "khongthanhcong");
                return Page();
            }
            return Page();
        }
        public IActionResult OnPostTong()
        {
            string idtour = HttpContext.Session.GetString("chitiettour");
            List<DoanDuLichDTO> list = new DoanDuLichBUS().List().FindAll(x => x.Id_Tour.Equals(idtour));

            var parsedDate1 = DateTime.ParseExact(search1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            search1 = parsedDate1.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var parsedDate2 = DateTime.ParseExact(search2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            search2 = parsedDate2.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            ThongKeBUS bus = new ThongKeBUS();
            khachsan = bus.chiphikhachsan(list, search1, search2).ToString();
            anuong = bus.chiphianuong(list, search1, search2).ToString();
            phuongtien = bus.chiphiphuongtien(list, search1, search2).ToString();
            sodoan = bus.sodoan(list, search1, search2).ToString();
            doanhso = bus.doanhso(list, search1, search2).ToString();
            tong = bus.tongtatca(list, search1, search2).ToString();

            HttpContext.Session.SetString("thongketimkiem", "thanhcong");
            HttpContext.Session.SetString("khachsan", khachsan);
            HttpContext.Session.SetString("anuong", anuong);
            HttpContext.Session.SetString("phuongtien", phuongtien);
            HttpContext.Session.SetString("sodoan", sodoan);
            HttpContext.Session.SetString("doanhso", doanhso);
            HttpContext.Session.SetString("tong", tong);


            return Page();
        }
    }
}
