using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpfExample01_1.Services;
using wpfExample01_1.Utilty;

namespace wpfExample01_1.ViewModels
{
	public class BookViewModel : ObservableObject
	{
		private IContactDataService _service;

		private ContactsViewModel _contactsVM;
		public ContactsViewModel ContactsVM
		{
			get { return _contactsVM; }
			set { OnPropertyChanged(ref _contactsVM, value); }
		}

		public ICommand LoadFavoritesCommand { get; private set; } // 읽기 전용
		public ICommand LoadContactsCommand { get; private set; } // 읽기 전용

		public BookViewModel(IContactDataService service)
		{
			ContactsVM = new ContactsViewModel();

			_service = service;

			LoadFavoritesCommand = new RelayCommand(LoadFavorites);
			LoadContactsCommand = new RelayCommand(LoadContacts);

		}

		public void LoadContacts()
		{
			ContactsVM.LoadContacts(_service.GetContacts());
		}

		public void LoadFavorites()
		{
			var favorites = _service.GetContacts().Where(c => c.IsFavorite);
			ContactsVM.LoadContacts(favorites);
		}
	}
}
