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
    public class FacilityEditViewModel
    {
        private FacilityEditService facilityEditService { get; set; }
        public FacilityEditView facilityEditView { get; set; }

        public FacilityEditViewModel(FacilityEditView view)
        {
            facilityEditService = new FacilityEditService(view);
            facilityEditView = view;
        }

        public ICommand selectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                {
                    selectCommand = new RelayCommand(facilityEditService.SelectFacility);
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
                    addCommand = new RelayCommand(facilityEditService.AddFacility);
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
                    deleteCommand = new RelayCommand(facilityEditService.DeleteFacility);
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
                    editCommand = new RelayCommand(facilityEditService.UpdateFacility);
                }
                return editCommand;
            }
        }
    }
}
