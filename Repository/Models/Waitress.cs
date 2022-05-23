using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public class Waitress
    {
        public int Id { get; }
        public int PinCode { get; }
        public string Name { get; }
        public string Surname { get; }
        public List<Table> TableList { get; }

        public Waitress(int id, int pinCode, string name, string surname, List<Table> tableList )
        {
            Id = id;
            PinCode = pinCode;
            Name = name;
            Surname = surname;
            TableList = tableList;
        }
    }
}
