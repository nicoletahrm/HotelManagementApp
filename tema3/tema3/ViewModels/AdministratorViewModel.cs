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
    public class AdministratorViewModel
    {
        private AdministratorService administratorService { get; set; }
        public AdministratorViewModel()
        {
            administratorService = new AdministratorService();
        }

        private ICommand editRooms;
        public ICommand EditRooms
        {
            get
            {
                if (editRooms == null)
                {
                    editRooms = new RelayCommand(administratorService.EditRooms);
                }
                return editRooms;
            }
        }

        private ICommand editFacilities;
        public ICommand EditFacilities
        {
            get
            {
                if (editFacilities == null)
                {
                    editFacilities = new RelayCommand(administratorService.EditFacilities);
                }
                return editFacilities;
            }
        }

        private ICommand editServices;
        public ICommand EditServices
        {
            get
            {
                if (editServices == null)
                {
                    editServices = new RelayCommand(administratorService.EditServices);
                }
                return editServices;
            }
        }

        private ICommand editOffers;
        public ICommand EditOffers
        {
            get
            {
                if (editOffers == null)
                {
                    editOffers = new RelayCommand(administratorService.EditOffers);
                }
                return editOffers;
            }
        }

        private ICommand editImages;
        public ICommand EditImages
        {
            get
            {
                if (editImages == null)
                {
                    editImages = new RelayCommand(administratorService.EditImages);
                }
                return editImages;
            }
        }

        private ICommand editRoomsFacilities;
        public ICommand EditRoomsFacilities
        {
            get
            {
                if (editRoomsFacilities == null)
                {
                    editRoomsFacilities = new RelayCommand(administratorService.EditRoomsFacilities);
                }
                return editRoomsFacilities;
            }
        }


        private ICommand editRoomsOffers;
        public ICommand EditRoomsOffers
        {
            get
            {
                if (editRoomsOffers == null)
                {
                    editRoomsOffers = new RelayCommand(administratorService.EditRoomsOffers);
                }
                return editRoomsOffers;
            }
        }

        private ICommand editRoomsImages;
        public ICommand EditRoomsImages
        {
            get
            {
                if (editRoomsImages == null)
                {
                    editRoomsImages = new RelayCommand(administratorService.EditRoomsImages);
                }
                return editRoomsImages;
            }
        }
    }
}
