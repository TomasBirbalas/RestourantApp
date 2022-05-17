using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public abstract class Product
    {
        public abstract int Id { get;}
        public abstract string Name { get; }
        public abstract decimal Price { get; }
    }
}
