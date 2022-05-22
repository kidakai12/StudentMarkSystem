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
    public class QuanLyNhanVien_SuaModel : PageModel
    {
        [BindProperty]
        public NhanVienDTO nhanvien { set; get; }
        [BindProperty]
        public string gioitinh { set; get; }
        public void OnGet()
        {
            var str = HttpContext.Session.GetString("editnhanvien");
            var obj = JsonConvert.DeserializeObject<NhanVienDTO>(str);

            gioitinh = obj.Gioitinh_NV;
        }
        public IActionResult OnPost()
        {
            nhanvien.Tinh_Trang = 1;
            nhanvien.Gioitinh_NV = gioitinh;
            if (new NhanVienBUS().Update(nhanvien))
            {
                HttpContext.Session.SetString("suanhanvien", "true");
                return Redirect("/Shared/QuanLyNhanVien");
            }
            HttpContext.Session.SetString("suanhanvien", "false");
            return Page();
        }
    }
}
