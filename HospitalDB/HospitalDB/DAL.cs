using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDB
{
    public class DAL
    {
      public static string GetConnect
        {
            get { return "Data Source =DESKTOP-HQ54VJP\\SQLEXPRESS01; Initial Catalog = Northwind; Integrated Security = True"; }
        }
    }
}
