using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using tema3.Help;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.ViewModels;
using tema3.Views;

namespace tema3.Services
{
    public class RoomEditService
    {
        private readonly IGenericRepository<Room> _roomRepo;
        public RoomEditView roomEditView { get; set; }

        public RoomEditService(RoomEditView view)
        {
            roomEditView = view;
            _roomRepo = new GenericRepository<Room>(new AppDbContext());
        }

        public void SelectRoom(Object sender)
        {
            Room room = (Room)roomEditView.ListBox.SelectedItem;

            if (room == null)
            {
                throw new HotelException("Trebuie selectata o camera.");
                //MessageBox.Show("Unable to save file, try again.");
            }

            roomEditView.RoomTypeTextBox.Text = room.RoomType;
            roomEditView.PriceTextBox.Text = room.Price.ToString();
            roomEditView.NumberOfRoomsTextBox.Text = room.NumberOfRooms.ToString();

            string s = "No";
            if (room.IsActive == true)
                s = "Yes";

            roomEditView.ComboBox.Text = s;
        }

        public void AddRoom(Object sender)
        {
            bool active = false;

            if (roomEditView.ComboBox.SelectedItem.ToString() == "Yes")
                active= true;

            Room room = new Room() { RoomType = roomEditView.RoomTypeTextBox.Text, Price = int.Parse(roomEditView.PriceTextBox.Text), NumberOfRooms = int.Parse(roomEditView.NumberOfRoomsTextBox.Text), IsActive = active };
            _roomRepo.Insert(room);
            roomEditView.ListBox.Items.Refresh();
        }

        public void DeleteRoom(Object sender)
        {
            Room room = (Room)roomEditView.ListBox.SelectedItem;

            if (room == null)
            {
                throw new HotelException("Trebuie selectata o camera.");
            }

            room.IsActive = false;
            roomEditView.ListBox.Items.Refresh();
        }

        public void UpdateRoom(Object sender)
        {
            Room room = (Room)roomEditView.ListBox.SelectedItem;

            if (room == null)
            {
                throw new HotelException("Trebuie selectata o camera.");
            }

            room.RoomType = roomEditView.RoomTypeTextBox.Text;
            room.Price = int.Parse(roomEditView.PriceTextBox.Text);
            room.NumberOfRooms = int.Parse(roomEditView.NumberOfRoomsTextBox.Text);

            string s = roomEditView.ComboBox.Text;

            bool x = false;
            if (s == "Yes")
                x = true;

            room.IsActive = x;

            _roomRepo.Update(room);

            roomEditView.ListBox.Items.Refresh();
        }
    }
}
