using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParamReviews.Data
{
    public class EmployeeBusiness
    {
        public static List<Employee> EmployeesList()
        {
            var list = new List<Employee> {
                 new Employee{Id="EL000-8", Name="Martha Jimenez", BossId=""},
                 new Employee{Id="EL125-5", Name="Joseto Benitez", BossId="EL000-8"},
                 new Employee{Id="R0P23-1", Name="Vicente Orjuela", BossId="EL000-8"},
                 new Employee{Id="PL032-5", Name="Paula Smith", BossId="R0P23-1"},
                 new Employee{Id="PLP25-3", Name="Hector Rodriguez", BossId="R0P23-1"},
                 new Employee{Id="ARS00-2", Name="Marcos Zapata", BossId="EL125-9"},
                 new Employee{Id="AS100-7", Name="Juanita Rosales", BossId="EL125-9"},
                 new Employee{Id="PL858-2", Name="Orlando Blanco", BossId="EL125-9"}
            };

            return list;
        }
    }
}
