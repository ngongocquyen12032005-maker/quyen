using System;

namespace PhoneBook
{
    internal class ContactRepository
    {
        private Contact[] _contactArr;
        private int _count;
        private int _nextId;

        public ContactRepository(int numberOfContact)
        {
            _contactArr = new Contact[numberOfContact];
            _count = 0;
            _nextId = 1;
        }

        public int GetCount()
        {
            return _count;
        }

        public Contact CreateNewContact()
        {
            Contact contact = new Contact(_nextId);
            _nextId++;
            return contact;
        }

        public bool IsPhoneExist(string phone)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_contactArr[i].GetPhone() == phone)
                    return true;
            }
            return false;
        }

        public void Add(Contact contact)
        {
            if (_count >= _contactArr.Length)
            {
                throw new Exception("Danh ba da day!");
            }

            if (IsPhoneExist(contact.GetPhone()))
            {
                throw new Exception("Phone da ton tai!");
            }

            _contactArr[_count] = contact;
            _count++;
        }

        public void PrintAllContacts()
        {
            if (_count == 0)
            {
                Console.WriteLine("Danh sach rong.");
                return;
            }

            for (int i = 0; i < _count; i++)
            {
                _contactArr[i].DisplayString();
            }
        }
    }
}
