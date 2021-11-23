using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Enum
{
    [DataContract]
    public enum FeedingType
    {
        [EnumMember]
        RoomOnly = 0,
        [EnumMember]
        AllInclusive = 1,
        [EnumMember]
        FullBoard = 2,
        [EnumMember]
        BedAndBreakfast = 3,
    }
}
