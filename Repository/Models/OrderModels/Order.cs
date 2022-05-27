using Repository.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.OrderModels
{
    public class Order
    {
        public int Id { get; set; } = 1;
        public DateTime Created { get; }
        public List<OrderProduct> OrderProducts { get; }
        public decimal OrderTotalAmount { get; }

        public Order()
        {
            Id = Id++;
            Created = DateTime.Now;
            OrderProducts = new List<OrderProduct>();
            OrderTotalAmount = 0;
        }
    }
}
