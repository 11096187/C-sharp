using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Persontest
{
    class Person
    {
		// Automatic property zonder invoercontrole
        public string FirstName 
		{ 
			get; 
			set; 
		}

		// Inclusief invoercontrole
		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set 
			{
				if (value.Length < 3)
					throw new ArgumentException("Name too short!");
				else
					_lastName = value; 
			}
		}

		private DateTime _birthday;

		public DateTime Birthday
		{
			get { return _birthday; }
			set { _birthday = value; }
		}

		// read-only property
		public string FullName
		{
			get { return FirstName + " " + LastName; }
		}

		// read-only property: vraag alleen maar iets op
		public int Age
		{
			get
			{
				// Define current date
				var today = DateTime.Now;

				// Calculate age
				var age = today.Year - Birthday.Year;
				
				// Go back to the year the person was born in case of a leap year
				if (Birthday.Date > today.AddYears(-age))
				{
					age--;
				}
				return age;

			}
		}

		// Constructor for initialization: zorg ervoor dat het object een naam krijgt
		public Person(string firstname)
		{
			this.FirstName = firstname;
		}

		public Person (string firstname, string lastname)
		{
			this.FirstName = firstname;
			this.LastName = lastname;
		}

		public Person ()
		{
		}
	}
}
