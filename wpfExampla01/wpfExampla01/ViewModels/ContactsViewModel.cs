﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfExampla01.Models;
using wpfExampla01.Utilty;

namespace wpfExampla01.ViewModels
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

		public ObservableCollection<Contact> Contacts { get; set; }

		public ContactsViewModel()
		{

		}

		public void LoadContacts(IEnumerable<Contact> contacts)
		{
			Contacts = new ObservableCollection<Contact>(contacts);
			OnPropertyChanged("Contacts");
		}
	}
}
