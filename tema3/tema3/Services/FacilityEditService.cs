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
    public class FacilityEditService
    {
        private readonly IGenericRepository<Facility> _facilityRepo;
        public FacilityEditView facilityEditView { get; set; }

        public FacilityEditService(FacilityEditView view)
        {
            facilityEditView = view;
            _facilityRepo = new GenericRepository<Facility>(new AppDbContext());
        }

        public void SelectFacility(Object sender)
        {
            Facility facility = (Facility)facilityEditView.ListBox.SelectedItem;

            if (facility == null)
            {
                throw new HotelException("Trebuie selectata o dotare.");
                //MessageBox.Show("Unable to save file, try again.");
            }

            facilityEditView.FacilityTypeTextBox.Text = facility.FacilityType;

            string s = "No";
            if (facility.IsActive == true)
                s = "Yes";

            facilityEditView.ComboBox.Text = s;
        }

        public void AddFacility(Object sender)
        {
            bool active = false;

            if (facilityEditView.ComboBox.SelectedItem.ToString() == "Yes")
                active = true;

            Facility facility = new Facility() { FacilityType = facilityEditView.FacilityTypeTextBox.Text, IsActive = active };
            _facilityRepo.Insert(facility);

            facilityEditView.ListBox.Items.Refresh();
        }

        public void DeleteFacility(Object sender)
        {
            Facility facility = (Facility)facilityEditView.ListBox.SelectedItem;

            if (facility == null)
            {
                throw new HotelException("Trebuie selectata o dotare.");
                //MessageBox.Show("Unable to save file, try again.");
            }

            facility.IsActive = false;
            _facilityRepo.Update(facility);
        }

        public void UpdateFacility(Object sender)
        {
            Facility facility = (Facility)facilityEditView.ListBox.SelectedItem;

            if (facility == null)
            {
                throw new HotelException("Trebuie selectata o dotare.");
            }

            facility.FacilityType = facilityEditView.FacilityTypeTextBox.Text;

            string s = facilityEditView.ComboBox.Text;

            bool x = false;
            if (s == "Yes")
                x = true;

            facility.IsActive = x;

            _facilityRepo.Update(facility);

            facilityEditView.ListBox.Items.Refresh();
        }
    }
}
