using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema3.Services;
using tema3.Views;

namespace tema3.ViewModels
{
    public class EditViewModel
    {
        private EditService editService { get; set; }
        public EditView editView { get; set; }

        public EditViewModel(EditView view)
        {
            editService = new EditService(view);
            editView = view;
        }
    }
}
