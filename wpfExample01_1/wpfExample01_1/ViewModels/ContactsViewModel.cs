using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfExample01_1.Models;
using wpfExample01_1.Utilty;

namespace wpfExample01_1.ViewModels
{
	public class ContactsViewModel : ObservableObject
	{
		private Contact _selectedContact;
		public Contact SelectedContact
		{
			get { return _selectedContact; }
			set
			{
				OnPropertyChanged(ref _selectedContact, value);
			}
		}

		public ObservableCollection<Contact> Contacts { get; private set; }

		public ContactsViewModel()
		{

		}

		public void LoadContacts(IEnumerable<Contact> contacts)
		{
			Contacts = new ObservableCollection<Contact>(contacts);
			OnPropertyChanged("Contacts"); // Contacts 프로퍼티가 갱신 되었다고 알려준다.
		}

	}
}
