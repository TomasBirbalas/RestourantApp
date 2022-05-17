using System;

namespace Repository.Models
{
    public class Waitress
    {
        int Id { get; }
        int PinCode { get; }
        string Name { get; }
        string Surname { get; }
        List<Table> TableList { get; }

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
