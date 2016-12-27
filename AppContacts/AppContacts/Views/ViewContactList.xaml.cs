using System;
using System.Collections.Generic;
using AppContacts.Models;
using AppContacts.ViewModels;

using Xamarin.Forms;

namespace AppContacts.Views
{
	public partial class ViewContactList : ContentPage
	{
		public ViewContactList()
		{
			InitializeComponent();

			AddContactButton.Clicked += (object sender, EventArgs e) =>
			{
				//ViewModelContact VMContact = new ViewModelContact();
				//VMContact.contact = new Contact();
				//var pageNewContact = new ViewNewContact();
				//pageNewContact.BindingContext = VMContact;


				Navigation.PushAsync(new ViewNewContact());
			};

			MessagingCenter.Subscribe<Contact>(this, "DetailContact", (sender) => {
				ViewModelContact VMContact = new ViewModelContact();
				VMContact.contact = sender;
				var pageViewContact = new ViewContact();
				pageViewContact.BindingContext = VMContact;
				Navigation.PushAsync(pageViewContact);
			});
		}
	}
}
