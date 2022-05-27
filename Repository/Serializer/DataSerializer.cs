using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Repository.Serializer
{
    public class DataSerializer
    {
        public void SerializeData<T>( string filePath, List<T> dataList)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }
            string jsonString = JsonSerializer.Serialize(dataList, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
