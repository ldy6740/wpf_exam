﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfExampla01.Models;

namespace wpfExampla01.Service
{
	public interface IContactDataService
	{
		IEnumerable<Contact> GetContacts();

		void Save(IEnumerable<Contact> contacts);
	}
}
