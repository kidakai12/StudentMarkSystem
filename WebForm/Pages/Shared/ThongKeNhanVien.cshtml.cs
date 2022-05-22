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
    public class ThongKeNhanVienModel : PageModel
    {
        [BindProperty]
        public string search1 { set; get; }
        [BindProperty]
        public string search2 { set; get; }

        public void OnGet()
        {
        }

        public IActionResult OnPostTong()
        {

            var parsedDate1 = DateTime.ParseExact(search1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            search1 = parsedDate1.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var parsedDate2 = DateTime.ParseExact(search2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            search2 = parsedDate2.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            HttpContext.Session.SetString("thongkenhanvien","thanhcong");
            HttpContext.Session.SetString("ngay1", search1);
            HttpContext.Session.SetString("ngay2", search2);

            return Page();
        }
    }
}
