using Repository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Repository.Deserializer
{
    public class JSONdeserializer
    {
        public List<Waitress> DeserializeWaitress(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            var jsonData = JsonSerializer.Deserialize<List<Waitress>>(jsonString, options);

            return jsonData;
        }
    }
}
