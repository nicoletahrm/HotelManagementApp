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
    public class ImageRoomEditViewModel
    {
        private ImageRoomEditService imageRoomEditService { get; set; }
        public ImageRoomEditView imageRoomEditView { get; set; }
        public ImageRoomEditViewModel(ImageRoomEditView view)
        {
            imageRoomEditService = new ImageRoomEditService(view);
            imageRoomEditView = view;
        }

        public ICommand selectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                {
                    selectCommand = new RelayCommand(imageRoomEditService.SelectImageRoom);
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
                    addCommand = new RelayCommand(imageRoomEditService.AddImageRoom);
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
                    deleteCommand = new RelayCommand(imageRoomEditService.DeleteImageRoom);
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
                    editCommand = new RelayCommand(imageRoomEditService.UpdateImageRoom);
                }
                return editCommand;
            }
        }
    }
}
