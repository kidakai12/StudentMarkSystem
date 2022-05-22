using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUS
{
    public class TourBUS
    {
        public TourBUS() { }

        public List<TourDTO> List()
        {
            return new TourDAO().ListAll();
        }
        public bool Update(TourDTO tour)
        {
            return new TourDAO().Update(tour);
        }

        public bool Insert(TourDTO tour)
        {
            return new TourDAO().Insert(tour);
        }
        public bool Delete(string matour)
        {
            return new TourDAO().Delete(matour);
        }
        public String MakeID()
        {
            return new TourDAO().MakeID();
        }
    }
}
