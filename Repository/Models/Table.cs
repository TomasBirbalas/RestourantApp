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
        public bool Status { get; }

        public Table(int id, int numberOfSeats, bool status)
        {
            Random random = new Random();

            Id = id;
            NumberOfSeats = numberOfSeats;
            Status = status;

        }
    }
}
