using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.OrderModels
{
    public class Order
    {
        public int Id { get; }
        public DateTime Created { get; }
        public List<OrderProduct> OrderProducts { get; }
        public decimal OrderTotalAmount { get; }

        public Order(int id)
        {
            Id = id;

            Created = DateTime.Now;
            OrderProducts = new List<OrderProduct>();
            OrderTotalAmount = 0;
        }
    }
}
