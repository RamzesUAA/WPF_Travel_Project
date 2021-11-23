using AutoMapper;
using Lab_5.Model;
using Lab_5.ViewModels;

namespace Lab_5.Automapper
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<DataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, DataModel>();

            Mapper.CreateMap<Travel, TravelViewModel>();
            Mapper.CreateMap<TravelViewModel, Travel>();

            Mapper.CreateMap<Hotel, HotelViewModels>();
            Mapper.CreateMap<HotelViewModels, Hotel>();

            Mapper.CreateMap<Client, ClientViewModel>();
            Mapper.CreateMap<ClientViewModel, Client>();
        }
    }
}
