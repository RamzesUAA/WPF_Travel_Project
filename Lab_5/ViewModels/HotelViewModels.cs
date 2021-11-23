using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_5.Enum;

namespace Lab_5.ViewModels
{
    public class HotelViewModels : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int _stars;
        public int Stars
        {
            get { return _stars; }
            set
            {
                _stars = value;
                OnPropertyChanged(nameof(Stars));
            }
        }

        private FeedingType _typeOfFeedings;
        public FeedingType TypeOfFeedings
        {
            get { return _typeOfFeedings; }
            set
            {
                _typeOfFeedings = value;
                OnPropertyChanged(nameof(TypeOfFeedings));
            }
        }
    }
}
