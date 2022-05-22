using System;
using System.Collections.Generic;
using System.Text;
using DAL;
namespace BUS
{
    public class Tool
    {
        public Tool() { }

        public string RemoveUnicodeBus(string txt)
        {
            return new RemoveUnicode().RemoveUnicodeTool(txt);
        }
        public int comparedate(string date1, string date2)
        {
            DateTime dt1 = DateTime.ParseExact(date1,
                "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact(date2, 
                "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            int result = DateTime.Compare(dt1,dt2);
            return result;
        }
        public int comparetoday(string date1)
        {
            DateTime dt1 = DateTime.ParseExact(date1,
                "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            int result = DateTime.Compare(dt1, DateTime.Today);
            return result;
        }
    }
}
