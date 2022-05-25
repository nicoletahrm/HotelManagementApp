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
    public class ImageRoomEditService
    {
        private readonly IGenericRepository<Room> _roomRepo;
        private readonly IGenericRepository<Image> _imageRepo;
        public ImageRoomEditView imageRoomEditView { get; set; }

        public ImageRoomEditService(ImageRoomEditView view)
        {
            imageRoomEditView = view;
            _roomRepo = new GenericRepository<Room>(new AppDbContext());
            _imageRepo = new GenericRepository<Image>(new AppDbContext());
        }

        public void SelectImageRoom(Object sender)
        {

        }

        public void AddImageRoom(Object sender)
        {
            Room room = (Room)imageRoomEditView.RoomsListBox.SelectedItem;
            Image image = (Image)imageRoomEditView.ImagesListBox.SelectedItem;

            room.Images.Add(image);
            image.Rooms.Add(room);

            _roomRepo.Update(room);
            _imageRepo.Update(image);
        }

        public void DeleteImageRoom(Object sender)
        {

        }

        public void UpdateImageRoom(Object sender)
        {

        }
    }
}
