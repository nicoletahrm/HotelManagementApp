using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema3.Help;
using tema3.Models.Entity;
using tema3.Services;
using tema3.Views;

namespace tema3.ViewModels
{
    public class EditViewModel : NotifyPropertyChangedBase
    {
        private EditService editService { get; set; }
        public EditView editView { get; set; }

        public EditViewModel(EditView view)
        {
            editService = new EditService(view);
            editView = view;
        }

        public Room selectedItem;

        public Room SelectedItem
        {
            get
            { 
                return selectedItem; 
            }
            set 
            { 
                selectedItem = value; 
                NotifyPropertyChanged("SelectedItem"); 
            }
        }

        public ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(editService.AddRoom);
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
                    deleteCommand = new RelayCommand(editService.DeleteRoom);
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
                    editCommand = new RelayCommand(editService.UpdateRoom);
                }
                return editCommand;
            }
        }
    }
}
