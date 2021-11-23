using System.IO;
using System.Runtime.Serialization;
using Lab_5.Model;

namespace Lab_5.Serialization
{
    public class DataSerializer
    {
        public static void SerializeData(string fileName, DataModel data)
        {
            var binaryFormatter = new DataContractSerializer(typeof(DataModel));
            using (var fileStreamCreate = new FileStream(fileName, FileMode.Create))
            {
                binaryFormatter.WriteObject(fileStreamCreate, data);
            }
        }

        public static DataModel DeserializeItem(string fileName)
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            using (var fileStreamOpen = new FileStream(fileName, FileMode.Open))
            {
                return formatter.ReadObject(fileStreamOpen) as DataModel;
            }
        }
    }
}
