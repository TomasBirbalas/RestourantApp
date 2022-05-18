using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.OrderModels
{
    public class Drink : Product
    {
        public int Capacity { get; set; }
        public Drink(string category, string name, int capacity, decimal price) : base(category, name, price)
        {
            Capacity = capacity;
        }
        public override string ToString()
        {
            return $"{Capacity} ml";
        }
    }
}
