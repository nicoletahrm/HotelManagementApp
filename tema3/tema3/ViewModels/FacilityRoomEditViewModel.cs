using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema3.Help;
using tema3.Views;

namespace tema3.ViewModels
{
    public class FacilityRoomEditViewModel
    {
        private FacilityRoomEditService facilityRoomEditService { get; set; }
        public FacilityRoomEditView facilityRoomEditView { get; set; }
        public FacilityRoomEditViewModel(RoomEditView view)
        {
            facilityRoomEditService = new FacilityRoomEditService(view);
            facilityRoomEditView = view;
        }

        public ICommand selectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                {
                    selectCommand = new RelayCommand(facilityRoomEditService.SelectRoom);
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
                    addCommand = new RelayCommand(facilityRoomEditService.AddRoom);
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
                    deleteCommand = new RelayCommand(facilityRoomEditService.DeleteRoom);
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
                    editCommand = new RelayCommand(facilityRoomEditService.UpdateRoom);
                }
                return editCommand;
            }
        }
    }
}
