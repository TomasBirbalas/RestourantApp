using Repository.Models.OrderModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Table
    {
        public int Id { get; }
        public int NumberOfSeats { get; }
        public TableStatus Status { get; }
        public Order Order { get; }
        public DateTime Created { get; }
        public DateTime Closed { get; }

        public Table(int id, TableStatus status)
        {
            Random random = new Random();

            Id = id;
            Status = status;

            NumberOfSeats = random.Next(2,9);
            //Order = new List<Order>();
        }
    }
}
