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
    public class OfferEditService
    {
        private readonly IGenericRepository<Offer> _offerRepo;
        public OfferEditView offerEditView { get; set; }

        public OfferEditService(OfferEditView view)
        {
            offerEditView = view;
            _offerRepo = new GenericRepository<Offer>(new AppDbContext());
        }

        public void SelectOffer(Object sender)
        {
            Offer offer = (Offer)offerEditView.ListBox.SelectedItem;

            if (offer == null)
            {
                throw new HotelException("Trebuie selectata o oferta.");
            }

            offerEditView.OfferTypeTextBox.Text = offer.OfferType;
            offerEditView.PriceTextBox.Text = offer.OfferPrice.ToString();
            offerEditView.StartDateBox.SelectedDate = offer.StartDate;
            offerEditView.EndDateBox.SelectedDate = offer.EndDate;

            string s = "No";
            if (offer.IsActive == true)
                s = "Yes";

            offerEditView.ComboBox.Text = s;
        }

        public void AddOffer(Object sender)
        {
            bool active = false;

            if (offerEditView.ComboBox.SelectedItem.ToString() == "Yes")
                active = true;

            Offer offer = new Offer() { OfferType = offerEditView.OfferTypeTextBox.Text, OfferPrice = int.Parse(offerEditView.PriceTextBox.Text), StartDate = offerEditView.StartDateBox.SelectedDate.Value, EndDate = offerEditView.EndDateBox.SelectedDate.Value, IsActive = active };
            _offerRepo.Insert(offer);

            offerEditView.ListBox.Items.Refresh();
        }

        public void DeleteOffer(Object sender)
        {
            Offer offer = (Offer)offerEditView.ListBox.SelectedItem;

            if (offer == null)
            {
                throw new HotelException("Trebuie selectata o oferta.");
            }

            offer.IsActive = false;
            _offerRepo.Update(offer);

            offerEditView.ListBox.Items.Refresh();
        }

        public void UpdateOffer(Object sender)
        {
            Offer offer = (Offer)offerEditView.ListBox.SelectedItem;

            if (offer == null)
            {
                throw new HotelException("Trebuie selectata o oferta.");
            }

            offer.OfferType = offerEditView.OfferTypeTextBox.Text;
            offer.OfferPrice = int.Parse(offerEditView.PriceTextBox.Text);
            offer.StartDate = offerEditView.StartDateBox.SelectedDate.Value;
            offer.EndDate = offerEditView.EndDateBox.SelectedDate.Value;

            string s = offerEditView.ComboBox.Text;

            bool x = false;
            if (s == "Yes")
                x = true;

            offer.IsActive = x;

            _offerRepo.Update(offer);

            offerEditView.ListBox.Items.Refresh();
        }
    }
}
