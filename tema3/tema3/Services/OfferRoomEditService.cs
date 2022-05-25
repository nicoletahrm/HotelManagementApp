using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class OfferRoomEditService
    {
        private readonly IGenericRepository<Room> _roomRepo;
        private readonly IGenericRepository<Offer> _offerRepo;
        public OfferRoomEditView offerRoomEditView { get; set; }

        public OfferRoomEditService(OfferRoomEditView view)
        {
            offerRoomEditView = view;
            _roomRepo = new GenericRepository<Room>(new AppDbContext());
            _offerRepo = new GenericRepository<Offer>(new AppDbContext());
        }

        public void SelectOfferRoom(Object sender)
        {

        }

        public void AddOfferRoom(Object sender)
        {
            Room room = (Room)offerRoomEditView.RoomsListBox.SelectedItem;
            Offer offer = (Offer)offerRoomEditView.OffersListBox.SelectedItem;

            room.Offers.Add(offer);
            offer.Rooms.Add(room);

            _roomRepo.Update(room);
            _offerRepo.Update(offer);
        }

        public void DeleteOfferRoom(Object sender)
        {

        }

        public void UpdateOfferRoom(Object sender)
        {

        }
    }
}
