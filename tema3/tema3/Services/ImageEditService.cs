using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Help;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class ImageEditService
    {
        private readonly IGenericRepository<Image> _imageRepo;
        public ImageEditView imageEditView { get; set; }

        public ImageEditService(ImageEditView view)
        {
            imageEditView = view;
            _imageRepo = new GenericRepository<Image>(new AppDbContext());
        }

        public void SelectImage(Object sender)
        {
            Image image = (Image)imageEditView.ListBox.SelectedItem;

            if (image == null)
            {
                throw new HotelException("Trebuie selectata o imagine.");
            }

            imageEditView.PathTextBlock.Text = image.Path;

            string s = "No";
            if (image.IsActive == true)
                s = "Yes";

            imageEditView.ComboBox.Text = s;
        }

        public void AddImage(Object sender)
        {
            bool active = false;

            if (imageEditView.ComboBox.SelectedItem.ToString() == "Yes")
                active = true;

            Image image = new Image() { Path = imageEditView.PathTextBlock.Text, IsActive = active };
            _imageRepo.Insert(image);

            imageEditView.ListBox.Items.Refresh();
        }

        public void DeleteImage(Object sender)
        {
            Image image = (Image)imageEditView.ListBox.SelectedItem;

            if (image == null)
            {
                throw new HotelException("Trebuie selectata o imagine.");
            }

            image.IsActive = false;

            imageEditView.ListBox.Items.Refresh();
        }

        public void UpdateImage(Object sender)
        {
            Image image = (Image)imageEditView.ListBox.SelectedItem;

            if (image == null)
            {
                throw new HotelException("Trebuie selectata o imagine.");
            }

            image.Path = imageEditView.PathTextBlock.Text;

            string s = imageEditView.ComboBox.Text;

            bool x = false;
            if (s == "Yes")
                x = true;

            image.IsActive = x;

            _imageRepo.Update(image);

            imageEditView.ListBox.Items.Refresh();
        }

        public void OpenImage(Object sender)
        {
            OpenFileDialog op = new OpenFileDialog();
            Image image = new Image();

            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";

            if (op.ShowDialog() == true)
            {
                imageEditView.PathTextBlock.Text = op.FileName;
            }
        }
    }
}
