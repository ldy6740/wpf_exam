using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfExampla01.Models;

namespace wpfExampla01.Service
{
	public class MockDataService :IContactDataService
	{
		private IEnumerable<Contact> _contacts;
		public MockDataService()
		{
			_contacts = new List<Contact>()
			{
				new Contact
				{
					FirstName = "John Doe",
					PhoneNumbers = new string[]
					{
						"555-555-111-1111",
						"555-555-222-2222"
					},
					Emails = new string[]
					{
						"johndoe@business.com",
						"johndoe@personal.com"
					},
					Locations = new string[]
					{
						"111 Fake Street",
						"222 Fake Street"
					},
				},
				new Contact
				{
					FirstName = "Jane Doe",
					PhoneNumbers = new string[]
					{
						"555-555-333-3333",
						"555-555-444-4444"
					},
					Emails = new string[]
					{
						"janedoe@business.com",
						"janedoe@personal.com"
					},
					Locations = new string[]
					{
						"333 Fake Street",
						"444 Fake Street"
					},
				},
			};
		}

		public IEnumerable<Contact> GetContacts()
		{
			return _contacts;
		}

		public void Save(IEnumerable<Contact> contacts)
		{
			_contacts = contacts;
		}
	}
}
