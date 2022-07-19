using ProjectAss.Models;
using System.Linq;

namespace ProjectAss.Logics
{
    public class EmployeeManager
    {
        public static Tblemployee CheckLogin(string username)
        {
            try
            {
                using (var contex = new prj_prnContext())
                {
                    var custo = contex.Tblemployees.First(x => x.Username.Equals(username));
                    return custo as Tblemployee;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
