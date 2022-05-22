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
    public class QuanLyChiPhi_SuaModel : PageModel
    {
        [BindProperty]
        public ChiPhiDTO chiphi { set; get; }

        [BindProperty]
        public string loai { set; get; }

        [BindProperty]
        public string phi { set; get; }
        public List<LoaiChiPhiDTO> loaichiphi { set; get; }
        public void OnGet()
        {
            loaichiphi = new LoaiChiPhiBUS().List();
            var str = HttpContext.Session.GetString("editchiphidoan");
            var obj = JsonConvert.DeserializeObject<ChiPhiDTO>(str);
            loai = obj.Id_LoaiChiPhi;
        }

        public IActionResult OnPostEdit()
        {
            string tmp = chiphi.Id_LoaiChiPhi;
            chiphi.Id_LoaiChiPhi = loai;
            if (new ChiPhiBUS().Update(chiphi,tmp))
            {
                long value2 = chiphi.Gia - long.Parse(phi);
                new DoanDuLichBUS().UpdateDoanhThu(chiphi.Id_Doan, value2);
                HttpContext.Session.SetString("suachiphi","thanhcong");
                return Redirect("/Shared/QuanLyChiTietDoan");
            }
            HttpContext.Session.SetString("suachiphi", "thatbai");
            return Page();
        }
    }
}
