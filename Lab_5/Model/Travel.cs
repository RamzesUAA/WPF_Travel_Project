using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xaml.Schema;

namespace Lab_5.Model
{
    [DataContract]
    public class Travel
    {
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public Hotel Hotel { get; set; }
        [DataMember]
        public bool IsAvailable { get; set; }
    }
}
