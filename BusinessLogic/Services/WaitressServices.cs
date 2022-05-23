using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class Global
    {
        public static int id;
        public static int pinCode;
    }
    public class WaitressServices
    {
        public Table GetNewTable(Waitress waitress, int personCount)
        {
            List<Table> tableList = waitress.TableList;

            tableList = tableList.FindAll(table => table.Status == false).ToList();
            return tableList.OrderBy(x => Math.Abs(x.NumberOfSeats - personCount)).First();
        }
    }

}
