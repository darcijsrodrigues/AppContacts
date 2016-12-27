using AppContacts.Models;
using System.Windows.Input;
using Xamarin.Forms;


namespace AppContacts.ViewModels
{
	public class ViewModelContact:BaseViewModel
	{
		public Contact contact = new Contact();

		private string _imgUrl { get; set; }
		public string ImgUrl { 
			get { return contact.imgUrl; }
			set
			{
				if (value != _imgUrl){
					_imgUrl = value;
					contact.imgUrl = value;
					NotifyPropertyChange("imgUrl");
				}
			}
		}

		private string _nome;
		public string Nome { 
			get { return contact.nome; }
			set {
				if (value != _nome) {
					_nome = value;
					contact.nome = value;
					NotifyPropertyChange("nome");
				}
			}
		}

		private string _sobreNome { get; set; }
		public string SobreNome { 
			get { return contact.sobreNome; }
			set {
				if (value != _sobreNome) {
					_sobreNome = value;
					contact.sobreNome = value;
					NotifyPropertyChange("sobreNome");
				}
			}
		}

		private string _telefone { get; set; }
		public string Telefone { 
			get { return contact.telefone;}
			set {
				if (value != _telefone) {
					_telefone = value;
					contact.telefone = value;
					NotifyPropertyChange("telefone");
				}
			}
		}

		private string _email { get; set; }
		public string Email { 
			get { return contact.email; }
			set {
				if (value != _email) {
					_email = value;
					contact.email = value;
					NotifyPropertyChange("email");
				}
			}
		}

		public ICommand AddContact { get; set; }

		public ViewModelContact()
		{
			this.AddContact = new Command(() => {
				MessagingCenter.Send<Contact>(this.contact, "NewContact");
			});
		}
	}
}
