using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfExample02.Models;
using wpfExample02.ViewModels.Bases;

namespace wpfExample02.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IList<Person>? _people;
        public IList<Person>? People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }

        private Person? _selectedPerson;
        public Person? SelectedPerson
        {
            get => _selectedPerson;
            set => SetProperty(ref _selectedPerson, value);
        }

        public MainWindowViewModel()
        {
            People = new List<Person>
            {
                new Person{Id = 292919, Name = "홍길동", Gender = true},
                new Person{Id = 230302, Name = "자랑동", Gender = true},
                new Person{Id = 123339, Name = "송정환", Gender = true},
                new Person{Id = 342553, Name = "차태현", Gender = true},
                new Person{Id = 229390, Name = "조인성", Gender = true},
                new Person{Id = 590388, Name = "한효주", Gender = true},
                new Person{Id = 483729, Name = "조세호", Gender = true},
                new Person{Id = 293848, Name = "이이경", Gender = true},
                new Person{Id = 987748, Name = "유재석", Gender = true},
                new Person{Id = 239498, Name = "강호동", Gender = false},
                new Person{Id = 675384, Name = "홍길이", Gender = true},
                new Person{Id = 192838, Name = "홍길남", Gender = true}
            };
        }
    }
}
