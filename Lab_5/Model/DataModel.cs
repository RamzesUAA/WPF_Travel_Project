using Lab_5.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Lab_5.Enum;

namespace Lab_5.Model
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Client> Clients { get; set; }

        [DataMember]
        public IEnumerable<Hotel> Hotels { get; set; }

        [DataMember]
        public IEnumerable<Travel> Travels { get; set; }

        public static string DataPath = "LocalDB.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }
            else
            {
                return new DataModel();
            }
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }

        public DataModel()
        {
            Hotels = new List<Hotel>()
            {
                new (){Name = "Mertvii Moskal", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Bandera House", TypeOfFeedings = FeedingType.BedAndBreakfast, Stars = 4},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Sun Rise", TypeOfFeedings = FeedingType.AllInclusive, Stars = 5},
                new (){Name = "Monte Karlo", TypeOfFeedings = FeedingType.RoomOnly, Stars = 3}
            };

            Travels = new List<Travel>()
            {
                new () {Country = "Ukraine", Hotel = Hotels.ElementAt(0), Location = "Lviv", Price = 400, IsAvailable = true},
                new () {Country = "Ukraine", Hotel = Hotels.ElementAt(2), Location = "Lviv", Price = 400, IsAvailable = true},
                new () {Country = "Turkey", Hotel = Hotels.ElementAt(3), Location = "Antalya", Price = 1200, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Usa", Hotel = Hotels.ElementAt(3), Location = "New York", Price = 600, IsAvailable = false},
                new () {Country = "Poland", Hotel = Hotels.ElementAt(3), Location = "Warsaw", Price = 700, IsAvailable = false}
            };

            Clients = new List<Client>()
            {
                new (){FirstName = "Roman", LastName = "Alberda", PassportNumber = "352132", Travels = new List<Travel>(){Travels.ElementAt(0)}},
                new (){FirstName = "Petro", LastName = "Porosheko", PassportNumber = "GETMAN228", Travels = new List<Travel>(){Travels.ElementAt(1)}},
                new (){FirstName = "Volodymyr", LastName = "Zelenskii", PassportNumber = "Vovchik111", Travels = new List<Travel>(){Travels.ElementAt(2)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Victor", LastName = "Yuishenko", PassportNumber = "Osa007", Travels = new List<Travel>(){Travels.ElementAt(3)}},
                new (){FirstName = "Stepan", LastName = "Bandera", PassportNumber = "KillMoskow", Travels = new List<Travel>(){Travels.ElementAt(3) }},
            };
        }
    }
}
