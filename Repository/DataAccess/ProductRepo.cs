using Repository.Models;
using Repository.Models.OrderModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess
{
    public class ProductRepo
    {
        List<Product> retrevieData = new List<Product>();

        public List<Product> RetrevieData()
        {
            var dataFile = File.ReadAllLines(@"..\..\..\..\DataFiles\food-menu.csv")
                .Skip(1)
                .Select(x => x.Split(','))
                .Select(x => new Food(
                    x[0],
                    x[1],
                    Enum.Parse<Portion>(x[2]),
                    decimal.Parse(x[3])
                )).ToList();
            retrevieData.AddRange(dataFile);
            return retrevieData;
        }
    }
}
