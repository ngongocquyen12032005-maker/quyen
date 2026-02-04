using System;

namespace PhoneBook
{
    internal class Contact
    {
        private int _id;
        private string _name;
        private string _phone;

        public Contact(int id)
        {
            _id = id;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetPhone(string phone)
        {
            _phone = phone;
        }

        public string GetPhone()
        {
            return _phone;
        }

        public void DisplayString()
        {
            Console.WriteLine($"ID: {_id} - Name: {_name} - Phone: {_phone}");
        }
    }
}
