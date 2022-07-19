using ProjectAss.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAss.Logics
{
    public class CustomerManager
    {
        public static Tblcustomer CheckLogin(string username)
        {
            try
            {
                using (var contex = new prj_prnContext())
                {
                    var custo = contex.Tblcustomers.First(x => x.CustomerUsername.Equals(username));
                    return custo as Tblcustomer;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
