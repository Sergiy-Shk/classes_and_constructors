using System;
using System.Linq;

namespace ConsoleApp3
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateTime;

        private bool IsOnlyLetters(string text)
        {
            return text.All(char.IsLetter);
        }

        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (IsOnlyLetters(value))
                {
                    _firstName = value;
                }
                else
                {
                    Console.WriteLine("Wrong first name!");
                    _firstName = "";
                }
            }
        }

        public string lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (IsOnlyLetters(value))
                {
                    _lastName = value;
                }
                else
                {
                    Console.WriteLine("Wrong last name!");
                    _lastName = "";
                }
            }
        }

        public string dateTime
        {
            get
            {
                return _dateTime.ToString("dd.MM.yyyy");
            }
            set
            {
                _dateTime = DateTime.Parse(value);
            }
        }

        public Person(string firstName, string lastName, DateTime date)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateTime = date.ToString("dd.MM.yyyy");
        }

        public Person(string lastName)
        {
            this.lastName = lastName;
            firstName = "FirstName";
            dateTime = DateTime.Parse("09/08/24").ToString("dd.MM.yyyy");
        }

        public Person(DateTime date)
        {
            firstName = "FirstName";
            lastName = "LastName";
            dateTime = date.ToString("dd.MM.yyyy");
        }

        public Person() : this("FirstName", "LastName", DateTime.Parse("09/08/24"))
        {
        }

        public override string ToString()
        {
            return "First name: " + firstName + "\n" + "Last name: " + lastName + "\n" + "Date: " + dateTime + "\n";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.ToString());
        }
    }
}
