using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class GiaBUS
    {
        public GiaBUS()
        {

        }
       public List<GiaDTO> List()
       {
            return new GiaDAO().List();
       }
       public bool Delete(string id)
       {
            return new GiaDAO().Delete(id);
       }
       public bool DeleteBaseTour(string idtour)
       {
            return new GiaDAO().DeleteBaseTour(idtour);
        }
       public bool Insert(GiaDTO gia)
       {
            return new GiaDAO().Insert(gia);
       }
       public bool Update(GiaDTO gia)
       {
            return new GiaDAO().Update(gia);
       }
        public String MakeID()
        {
            return new GiaDAO().MakeID();
        }
    }
}
