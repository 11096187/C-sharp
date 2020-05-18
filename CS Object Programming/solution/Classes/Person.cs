using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonTest
{
  class Person
  {

    public Person(string firstName, string lastName, DateTime birthday)
    {
      this.FirstName = firstName;
      this.LastName = lastName;
      this.Birthday = birthday;
    }
    public Person(string firstName, string lastName)
      : this(firstName, lastName, DateTime.Now)
    { }

    public string FirstName { get; set; }

    private string m_LastName;

    public string LastName
    {
      get { return m_LastName; }
      set
      {
        if (value.Length < 2)
          throw new ArgumentException("Name too short", "LastName");
        m_LastName = value;
      }
    }
    private DateTime m_Birthday;

    public DateTime Birthday
    {
      get { return m_Birthday; }
      set {
        if (value.Date.AddYears(18) > DateTime.Now.Date)
          throw new ArgumentException("Too young", "Birthday");
        if (value.Year < 1900)
          throw new ArgumentException("Too old", "Birthday");
        m_Birthday = value; 
      }
    }
    public string FullName
    {
      get
      {
        return this.FirstName + " " + this.LastName;
      }
    }

    public int Age
    {
      get
      {
        int y = DateTime.Now.Year - this.Birthday.Year;
        if (this.Birthday.AddYears(y).Date > DateTime.Now.Date)
          y--;
        return y;
      }
    }



  }
}
