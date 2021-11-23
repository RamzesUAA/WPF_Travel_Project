using System.Collections.ObjectModel;
using System.Windows.Input;
using Lab_5.Command;
using Lab_5.Model;

namespace Lab_5.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command.Command(ControlVisibility);
            ReversAvailability = new Command.Command(ReversAvailabilityCommand);
        }
        
        private string _visibleControl = "Travels";

        public ICommand SetControlVisibility { get; set; }
        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        public string VisibleControl
        {
            get => _visibleControl;
            set
            {
                _visibleControl = value;
                OnPropertyChanged(nameof(VisibleControl));
            }
        }



        public ICommand ReversAvailability { get; set; }
        public void ReversAvailabilityCommand(object args)
        {
            SelectedTravel.IsAvailable = !SelectedTravel.IsAvailable; 
        }




        private TravelViewModel _selectedTravel;

        public TravelViewModel SelectedTravel
        {
            get => _selectedTravel;
            set
            {
                _selectedTravel = value;
                OnPropertyChanged(nameof(SelectedTravel));
            }

        }


        private ObservableCollection<ClientViewModel> _clients { get; set; }
        public ObservableCollection<ClientViewModel> Clients
        {
            get => _clients;
            set
            {
                _clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }

        public ObservableCollection<HotelViewModels> _hotels { get; set; }
        public ObservableCollection<HotelViewModels> Hotels
        {
            get => _hotels;
            set
            {
                _hotels = value;
                OnPropertyChanged(nameof(Hotels));
            }
        }

        public ObservableCollection<TravelViewModel> _travels { get; set; }
        public ObservableCollection<TravelViewModel> Travels
        {
            get => _travels;
            set
            {
                _travels = value;
                OnPropertyChanged(nameof(Travels));
            }
        }
    }
}
