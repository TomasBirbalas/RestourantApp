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

            return tableList.FindAll(table => table.Status == false).Aggregate((current, next) => Math.Abs((int)current.NumberOfSeats - personCount) < Math.Abs((int)next.NumberOfSeats - personCount) ? current : next);
        }
        public void BookTable(ref Table table)
        {
            table.Status = true;
        }
    }

}
