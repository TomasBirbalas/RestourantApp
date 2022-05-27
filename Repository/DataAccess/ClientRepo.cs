using Repository.Deserializer;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess
{
    public class ClientRepo
    {
        private List<Client> clientList { get; }

        public ClientRepo()
        {
            JSONdeserializer deserializer = new JSONdeserializer();
            clientList = deserializer.DeserializeClient(@"..\..\..\..\DataFiles\clientJSON.json");
        }

        public List<Client> RetrieveClientList()
        {
            return clientList;
        }
        public Client RetrieveClient(int tableId)
        {
            return clientList.Find(client => client.TableID == tableId);
        }
    }
}
