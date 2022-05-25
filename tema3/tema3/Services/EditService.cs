using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class EditService
    {
        private readonly IGenericRepository<Room> _roomRepo;
        public EditView editView { get; set; }

        public EditService(EditView view)
        {
            editView = view;
            _roomRepo = new GenericRepository<Room>(new AppDbContext());
        }

        public void AddRoom(Object sender)
        {
            Room room = new Room() { RoomType = editView.RoomTypeTextBox.Text, Price = int.Parse(editView.PriceTextBox.Text), NumberOfRooms = int.Parse(editView.NumberOfRoomsTextBox.Text), IsActive = true };
            _roomRepo.Insert(room);
        }

        public void DeleteRoom(Object sender)
        {
            Room room = (Room)editView.ListBox.SelectedItem;
            _roomRepo.Delete(room);
        }

        public void UpdateRoom(Object sender)
        {
            Room room = (Room)editView.ListBox.SelectedItem;

            editView.RoomTypeTextBox.Text = room.RoomType;
            editView.PriceTextBox.Text = room.Price.ToString();
            editView.NumberOfRoomsTextBox.Text = room.NumberOfRooms.ToString();

            room.RoomType = editView.RoomTypeTextBox.Text;
            room.Price = int.Parse(editView.PriceTextBox.Text);
            room.NumberOfRooms = int.Parse(editView.NumberOfRoomsTextBox.Text);

            _roomRepo.Update(room);
        }
    }
}
