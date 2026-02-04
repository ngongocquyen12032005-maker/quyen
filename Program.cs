using System;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactRepository repo = new ContactRepository(10);

            while (true)
            {
                Console.WriteLine("\n===== PHONEBOOK MENU =====");
                Console.WriteLine("1. Them contact");
                Console.WriteLine("2. Hien thi danh ba");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                    break;

                switch (choice)
                {
                    case "1":
                        AddContact(repo);
                        break;

                    case "2":
                        repo.PrintAllContacts();
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }

        static void AddContact(ContactRepository repo)
        {
            Contact contact = repo.CreateNewContact();

            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            contact.SetName(name);

            Console.Write("Nhap so dien thoai: ");
            string phone = Console.ReadLine();
            contact.SetPhone(phone);

            try
            {
                repo.Add(contact);
                Console.WriteLine("Them contact thanh cong!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
    }
}
