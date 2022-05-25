using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class FacilityRoomEditService
    {
        private readonly IGenericRepository<Room> _roomRepo;
        private readonly IGenericRepository<Facility> _facilityRepo;
        public FacilityRoomEditView facilityRoomEditView { get; set; }

        public FacilityRoomEditService(FacilityRoomEditView view)
        {
            facilityRoomEditView = view;
            _roomRepo = new GenericRepository<Room>(new AppDbContext());
            _facilityRepo = new GenericRepository<Facility>(new AppDbContext());
        }

        public void SelectFacilitiesRooms(Object sender)
        {

        }

        public void AddFacilityRoom(Object sender)
        {
            Room room = (Room)facilityRoomEditView.RoomsListBox.SelectedItem;
            Facility facility = (Facility)facilityRoomEditView.FacilitiesListBox.SelectedItem;

            room.Facilities.Add(facility);
            facility.Rooms.Add(room);

            _roomRepo.Update(room);
            _facilityRepo.Update(facility);
        }

        public void DeleteFacilityRoom(Object sender)
        {
           
        }

        public void UpdateFacilityRoom(Object sender)
        {
           
        }
    }
}
