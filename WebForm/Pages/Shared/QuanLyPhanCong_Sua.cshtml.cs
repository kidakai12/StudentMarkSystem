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
    public class QuanLyPhanCong_SuaModel : PageModel
    {
        [BindProperty]
        public PhanCongDTO phancong { set; get; }
        [BindProperty]
        public string iddoan { set; get; }
        [BindProperty]
        public string idnv { set; get; }

        public List<DoanDuLichDTO> listdoan { get; set; }
        public List<NhanVienDTO> listnv { get; set; }
        public void OnGet()
        {
            listdoan = new DoanDuLichBUS().List();
            listnv = new NhanVienBUS().List();
            var str = HttpContext.Session.GetString("editphancong");
            var obj = JsonConvert.DeserializeObject<PhanCongDTO>(str);
            iddoan = obj.Id_Doan;
            idnv = obj.Id_NV;
        }
        public IActionResult OnPostEdit()
        {
            
            if (new PhanCongBUS().Update(new PhanCongDTO(
                iddoan,
                idnv,
                phancong.Nhiemvu),phancong.Id_Doan,phancong.Id_NV))
            {
                HttpContext.Session.SetString("suaphancong", "true");
                return Redirect("/Shared/QuanLyPhanCong");
            }
            HttpContext.Session.SetString("suaphancong", "false");
            return Redirect("/Shared/QuanLyPhanCong");
        }
    }
}
