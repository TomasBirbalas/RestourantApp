using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Client
    {
        public int PersonCount { get; }
        public int TableID { get; set; }

        public Client(int personCount, int tableId)
        {
            PersonCount = personCount;
            TableID = tableId;
        }
    }
}
