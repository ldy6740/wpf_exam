using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfExample01_1.Models;

namespace wpfExample01_1.Services
{
	public interface IContactDataService
	{
		IEnumerable<Contact> GetContacts();
		void Save(IEnumerable<Contact> contacts);
	}
}
