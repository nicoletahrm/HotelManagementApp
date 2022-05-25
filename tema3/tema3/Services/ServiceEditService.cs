using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Help;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class ServiceEditService
    {
        private readonly IGenericRepository<Service> _serviceRepo;
        public ServiceEditView serviceEditView { get; set; }

        public ServiceEditService(ServiceEditView view)
        {
            serviceEditView = view;
            _serviceRepo = new GenericRepository<Service>(new AppDbContext());
        }

        public void SelectService(Object sender)
        {
            Service service = (Service)serviceEditView.ListBox.SelectedItem;

            if (service == null)
            {
                throw new HotelException("Trebuie selectat un serviciu.");
            }

            serviceEditView.ServiceTypeTextBox.Text = service.ServiceName;

            string s = "No";
            if (service.IsActive == true)
                s = "Yes";

            serviceEditView.ComboBox.Text = s;
        }

        public void AddService(Object sender)
        {
            bool active = false;

            if (serviceEditView.ComboBox.SelectedItem.ToString() == "Yes")
                active = true;

            Service service = new Service() { ServiceName = serviceEditView.ServiceTypeTextBox.Text, IsActive = active };
            _serviceRepo.Insert(service);
        }

        public void DeleteService(Object sender)
        {
            Service service = (Service)serviceEditView.ListBox.SelectedItem;
            //service.IsActive = false;
            _serviceRepo.Delete(service);
        }

        public void UpdateService(Object sender)
        {
            Service service = (Service)serviceEditView.ListBox.SelectedItem;

            service.ServiceName = serviceEditView.ServiceTypeTextBox.Text;

            string s = serviceEditView.ComboBox.Text;

            bool x = false;
            if (s == "Yes")
                x = true;

            service.IsActive = x;

            _serviceRepo.Update(service);
        }
    }
}
