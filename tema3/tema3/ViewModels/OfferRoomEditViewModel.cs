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
    public class OfferRoomEditViewModel
    {
        private OfferRoomEditService offerRoomEditService { get; set; }
        public OfferRoomEditView offerRoomEditView { get; set; }
        public OfferRoomEditViewModel(OfferRoomEditView view)
        {
            offerRoomEditService = new OfferRoomEditService(view);
            offerRoomEditView = view;
        }

        public ICommand selectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                {
                    selectCommand = new RelayCommand(offerRoomEditService.SelectOfferRoom);
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
                    addCommand = new RelayCommand(offerRoomEditService.AddOfferRoom);
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
                    deleteCommand = new RelayCommand(offerRoomEditService.DeleteOfferRoom);
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
                    editCommand = new RelayCommand(offerRoomEditService.UpdateOfferRoom);
                }
                return editCommand;
            }
        }
    }
}
