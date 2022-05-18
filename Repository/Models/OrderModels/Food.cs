using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.OrderModels
{
    public class Food : Product
    {
        public Portion Portion { get; set; }

        public Food(string category, string name, Portion portion, decimal price): base(category, name, price)
        {
            Portion = portion;
        }
        public override string ToString()
        {
            return $"{Portion}";
        }
    }
}
