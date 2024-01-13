using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpfExample01_1.Models;
using wpfExample01_1.Services;
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

		private bool _isEditMode;
		public bool IsEditMdoe
		{
			get { return _isEditMode; }
			set
			{
				OnPropertyChanged(ref _isEditMode, value);
				OnPropertyChanged("IsDisplayMode");
			}
		}

		public bool IsDisplayMode
		{
			get { return !_isEditMode; }
		}

		private IEnumerable<Contact> _contacts;

		public ObservableCollection<Contact> Contacts { get; private set; }
		public ICommand EditCommand { get; private set; }
		public ICommand SaveCommand { get; private set; }
		public ICommand UpdateCommand { get; private set; }

		private IContactDataService _dataService;

		public ContactsViewModel(IContactDataService dataService, IDialogService dialogService)
		{
			_dataService = dataService;
			_contacts = dataService.GetContacts();

			EditCommand = new RelayCommand(Edit, CanEdit);
			SaveCommand = new RelayCommand(Save, IsEdit);
			UpdateCommand = new RelayCommand(Update);
		}

		private void Update()
		{
			_dataService.Save(_contacts);
		}

		private void Save()
		{
			_dataService.Save(_contacts);
			_isEditMode = false;
			OnPropertyChanged("SelectedContact");
		}
		
		private bool IsEdit()
		{
			return _isEditMode;
		}

		private bool CanEdit()
		{
			if (SelectedContact == null)
				return false;

			return !_isEditMode;
		}

		private void Edit()
		{
			_isEditMode = true;
		}

		public void LoadContacts(IEnumerable<Contact> contacts)
		{
			Contacts = new ObservableCollection<Contact>(contacts);
			OnPropertyChanged("Contacts"); // Contacts 프로퍼티가 갱신 되었다고 알려준다.
		}

	}
}
