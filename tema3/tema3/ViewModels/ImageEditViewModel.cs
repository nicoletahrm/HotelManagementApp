using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema3.Help;
using tema3.Services;
using tema3.Views;

namespace tema3.ViewModels
{
    public class ImageEditViewModel
    {
        private ImageEditService imageEditService { get; set; }
        public ImageEditView imageEditView { get; set; }
        public ImageEditViewModel(ImageEditView view)
        {
            imageEditService = new ImageEditService(view);
            imageEditView = view;
        }

        public ICommand selectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                {
                    selectCommand = new RelayCommand(imageEditService.SelectImage);
                }
                return selectCommand;
            }
        }

        public ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(imageEditService.AddImage);
                }
                return addCommand;
            }
        }

        public ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(imageEditService.DeleteImage);
                }
                return deleteCommand;
            }
        }

        public ICommand editCommand;
        public ICommand EditCommand
        {
            get
            {
                if (editCommand == null)
                {
                    editCommand = new RelayCommand(imageEditService.UpdateImage);
                }
                return editCommand;
            }
        }

        public ICommand openImage;
        public ICommand OpenImage
        {
            get
            {
                if (openImage == null)
                {
                    openImage = new RelayCommand(imageEditService.OpenImage);
                }
                return openImage;
            }
        }
    }
}
