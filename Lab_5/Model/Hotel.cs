using System.Collections.Generic;
using Lab_5.Enum;

namespace Lab_5.Model
{
    public class Hotel
    {
        public string Name { get; set; }
        public int Stars { get; set; }
        public FeedingType TypeOfFeedings { get; set; }

        public override string ToString()
        {
            return $"{Name} - stars: {Stars}";
        }
    }
}
