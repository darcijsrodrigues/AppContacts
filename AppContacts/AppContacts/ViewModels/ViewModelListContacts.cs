using System;
using AppContacts.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppContacts.ViewModels
{
	public class ViewModelListContacts:BaseViewModel
	{
		private ObservableCollection<Contact> _listContacts = new ObservableCollection<Contact>() {
			new Contact{nome="Zarb", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb1", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb2", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb3", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb4", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb5", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb6", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb7", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb8", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb9", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"},
			new Contact{nome="Zarb0", sobreNome="Solution",telefone="31 3166-0110",email="contato@zarbsolution.com.br"}
		};

		public ObservableCollection<Contact> ListContacts { 
			get { return _listContacts;}
			set {
				_listContacts = value;
				NotifyPropertyChange("ListContacts");
			}
		}

		private Contact _onItemSelected;
		public Contact OnItemSelected { 
			get { return _onItemSelected; }
			set {
				if (value != null)
					MessagingCenter.Send<Contact>(value, "DetailContact");
			}
		}

		public ViewModelListContacts()
		{
			MessagingCenter.Subscribe<Contact>("", "NewContact", (sender) =>
			{
				ListContacts.Add(sender);			
			});
		}
	}
}
