using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema3.Help;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Services;
using tema3.Views;

namespace tema3.ViewModels
{
    public class RoomEditViewModel : NotifyPropertyChangedBase
    {
        private RoomEditService roomEditService { get; set; }
        public RoomEditView roomEditView { get; set; }
        public RoomEditViewModel(RoomEditView view)
        {
            roomEditService = new RoomEditService(view);
            roomEditView = view;
        }

        public ICommand selectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                {
                    selectCommand = new RelayCommand(roomEditService.SelectRoom);
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
                    addCommand = new RelayCommand(roomEditService.AddRoom);
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
                    deleteCommand = new RelayCommand(roomEditService.DeleteRoom);
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
                    editCommand = new RelayCommand(roomEditService.UpdateRoom);
                }
                return editCommand;
            }
        }
    }
}
