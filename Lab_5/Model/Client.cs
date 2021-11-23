using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Model
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string PassportNumber { get; set; }

        [DataMember]
        public List<Travel> Travels { get; set; }


        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
