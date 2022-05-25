using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class AdministratorService
    {
        private readonly IGenericRepository<Room> _roomRepo;
        private readonly IGenericRepository<Facility> _facilityRepo;
        private readonly IGenericRepository<Offer> _offerRepo;
        private readonly IGenericRepository<Service> _serviceRepo;
        private readonly IGenericRepository<Image> _imageRepo;

        public ObservableCollection<Room> Rooms;
        public ObservableCollection<Facility> Facilities;
        public ObservableCollection<Offer> Offers;
        public ObservableCollection<Service> Services;
        public ObservableCollection<Image> Images;
        public AdministratorService()
        {
            _roomRepo = new GenericRepository<Room>(new AppDbContext());
            _facilityRepo = new GenericRepository<Facility>(new AppDbContext());
            _offerRepo = new GenericRepository<Offer>(new AppDbContext());
            _serviceRepo = new GenericRepository<Service>(new AppDbContext());
            _imageRepo = new GenericRepository<Image>(new AppDbContext());
        }
        public void EditRooms(Object sender)
        {
            var myObservableCollection = new ObservableCollection<Room>(_roomRepo.GetAll());
            Rooms = myObservableCollection;

            RoomEditView view = new RoomEditView("Rooms", Rooms);
            view.Show();
        }

        public void EditFacilities(Object sender)
        {
            var myObservableCollection = new ObservableCollection<Facility>(_facilityRepo.GetAll());
            Facilities = myObservableCollection;

            FacilityEditView view = new FacilityEditView("Facilities", Facilities);
            view.Show();
        }

        public void EditServices(Object sender)
        {
            var myObservableCollection = new ObservableCollection<Service>(_serviceRepo.GetAll());
            Services = myObservableCollection;

            ServiceEditView view = new ServiceEditView("Services", Services);
            view.Show();
        }

        public void EditOffers(Object sender)
        {
            var myObservableCollection = new ObservableCollection<Offer>(_offerRepo.GetAll());
            Offers = myObservableCollection;

            OfferEditView view = new OfferEditView("Offers", Offers);
            view.Show();
        }

        public void EditImages(Object sender)
        {
            var myObservableCollection = new ObservableCollection<Image>(_imageRepo.GetAll());
            Images = myObservableCollection;

            ImageEditView view = new ImageEditView("Images", Images);
            view.Show();
        }
    }
}
