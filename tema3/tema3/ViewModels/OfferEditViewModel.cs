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
    public class OfferEditViewModel
    {
        private OfferEditService offerEditService { get; set; }
        public OfferEditView offerEditView { get; set; }
        public OfferEditViewModel(OfferEditView view)
        {
            offerEditService = new OfferEditService(view);
            offerEditView = view;
        }

        public ICommand selectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                {
                    selectCommand = new RelayCommand(offerEditService.SelectOffer);
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
                    addCommand = new RelayCommand(offerEditService.AddOffer);
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
                    deleteCommand = new RelayCommand(offerEditService.DeleteOffer);
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
                    editCommand = new RelayCommand(offerEditService.UpdateOffer);
                }
                return editCommand;
            }
        }
    }
}
