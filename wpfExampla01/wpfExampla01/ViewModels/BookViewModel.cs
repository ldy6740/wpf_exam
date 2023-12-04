using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpfExampla01.Service;
using wpfExampla01.Utilty;

namespace wpfExampla01.ViewModels
{
	public class BookViewModel : ObservableObject
	{
		private IContactDataService _service;
		private ContactsViewModel _contactsVM;
		private MockDataService dataService;

		public ContactsViewModel ContactsVM
		{
			get { return _contactsVM; }
			set { OnPropertyChanged(ref _contactsVM, value); }
		}

		public ICommand LoadFavoritesCommand { get; private set; }
		public ICommand LoadContactsCommand { get; private set; }

		public BookViewModel(IContactDataService service)
		{
			ContactsVM = new ContactsViewModel();

			_service = service;

			LoadFavoritesCommand = new RelayCommand(LoadFavorites);
			LoadContactsCommand = new RelayCommand(LoadContacts);

		}

		public BookViewModel(MockDataService dataService)
		{
			this.dataService = dataService;
		}

		private void LoadContacts()
		{
			
			ContactsVM.LoadContacts(_service.GetContacts());
		}

		private void LoadFavorites()
		{
			var favorites = _service.GetContacts().Where(c => c.IsFavorite);
			ContactsVM.LoadContacts(favorites);
		}
	}
}
