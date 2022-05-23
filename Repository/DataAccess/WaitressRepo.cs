using Repository.Deserializer;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess
{
    public class WaitressRepo
    {
        //List<Waitress> waitressList = new List<Waitress>();
        private List<Waitress> waitressList { get; }

        public WaitressRepo()
        {
            JSONdeserializer deserializer = new JSONdeserializer();
            waitressList = deserializer.DeserializeWaitress(@"..\..\..\..\DataFiles\jsonData.json");
        }

        public List<Waitress> RetrieveWaitressList()
        {
            return waitressList;
        }
        public Waitress RetrieveWaitress(int id, int passcode)
        {
            return waitressList.Find(waitress => waitress.Id == id && waitress.PinCode == passcode);
        }
    }
}
