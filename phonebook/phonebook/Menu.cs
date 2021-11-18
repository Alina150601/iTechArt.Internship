using System;
using System.Linq;

namespace phonebook
{
    public class Menu
    {
        private readonly PhonebookContext _context;

        public Menu()
        {
            _context = new PhonebookContext();
        }

        public void PrintMenu()
        {
            Console.WriteLine("List of functions");
            Console.WriteLine("add <name> <phone>");
            Console.WriteLine("contacts");
            Console.WriteLine("edit <id> name <newname>");
            Console.WriteLine("edit <id> phone <newphone>");
            Console.WriteLine("delete <id>");
            while (true)
            {
                var command = Console.ReadLine().TrimEnd().Split(" ").ToArray();
                switch (command[0])
                {
                    case "add":
                        var name = command[1];
                        var phone = command[2];
                        var user = new Contact
                        {
                            Name = name,
                            Phone = phone
                        };
                        _context.Contacts.Add(user);
                        _context.SaveChanges();
                        Console.WriteLine("Contact was added!");
                        break;
                    case "contacts":
                        Console.WriteLine("List of contacts:");
                        var contacts = _context.Contacts.ToList();
                        var i = 1;
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine(i + " - " + contact);
                            i++;
                        }

                        break;
                    case "edit":
                        contacts = _context.Contacts.ToList();
                        if (command[2] == "phone")
                        {
                            int.TryParse(command[1], out var idContactToEdit);
                            var contactToEdit = contacts[idContactToEdit];
                            contactToEdit.Phone = command[3];
                            _context.SaveChanges();
                            Console.WriteLine("Contact was edited!");
                        }
                        else if (command[2] == "name")
                        {
                            int.TryParse(command[1], out var idContactToEdit);
                            var contactToEdit = contacts[idContactToEdit];
                            contactToEdit.Name = command[3];
                            _context.SaveChanges();
                            Console.WriteLine("Contact was edited!");
                        }
                        else
                        {
                            Console.WriteLine("Enter valid command please.");
                            break;
                        }

                        break;
                    case "delete":
                        Console.WriteLine("List of contacts:");
                        contacts = _context.Contacts.ToList();
                        i = 1;
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine(i + " - " + contact);
                            i++;
                        }

                        var secondWordIsNumber = int.TryParse(command[1], out var idContactToDelete);
                        if (secondWordIsNumber)
                        {
                            var contactToDelete = contacts[idContactToDelete];
                            _context.Contacts.Remove(contactToDelete);
                            _context.SaveChanges();
                            Console.WriteLine("Contact was deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No such contact. Try again.");
                            goto case "delete";
                        }

                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Enter valid command please.");
                        break;
                }
            }
        }
    }
}
