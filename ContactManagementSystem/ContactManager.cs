using System;
using System.Text.Json;

namespace ContactMangementSystem;

public class ContactManager
{
    private List<Contact> Contacts = new List<Contact>();

    public List<Contact> ReadContacts => Contacts;

    private string? ContactJson;

    // Add a new contact
    public void AddContact()
    {
        Console.WriteLine("Enter the contact's name: ");
        string? name = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }

        Console.WriteLine("Enter the contact's phone number: ");
        string? phone = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(phone))
        {
            Console.WriteLine("Phone number cannot be empty.");
            return;
        }

        Console.WriteLine("Enter the contact's email address: ");
        string? email = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Email address cannot be empty.");
            return;
        }

        Contact newContact = new Contact(name, phone, email);
        Contacts.Add(newContact);
        Console.WriteLine($"{name} added successfully!");
    }

    // Remove a contact
    public void RemoveContact()
    {
        for(int i = 0; i < ReadContacts.Count; i++)
        {
            Console.WriteLine($"{i+1} Name: {ReadContacts[i].Name} Phone: {ReadContacts[i].Phone} Email: {ReadContacts[i].Email}");
        }

        Console.WriteLine("Enter the menu item of the contact to remove: ");
        string? option = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(option) || !int.TryParse(option, out int choice) || choice < 1 || choice > ReadContacts.Count )
        {
            Console.WriteLine("Invalid option. Please try again.");
            return;
        }

        int Selected = choice -= 1; 

        Console.WriteLine($"{ReadContacts[Selected].Name} removed successfully!");
        Contacts.RemoveAt(Selected);


    }

    // List all contacts
    public void ListContacts()
    {
        if(ReadContacts.Count == 0)
        {
            Console.WriteLine("No contacts avaialble!");
            return;
        }
        foreach(var contact in ReadContacts)
        {
            Console.WriteLine($"Name: {contact.Name} Phone: {contact.Phone} Email: {contact.Email}");
        }
    }

   // Saving to json
   public string SaveToJson()
    {
        ContactJson = JsonSerializer.Serialize(Contacts);
        Console.WriteLine(ContactJson);
        return ContactJson;
    }

   // Loading from json 
   public void LoadFromJson()
    {
        List<Contact>? LoadContacts = JsonSerializer.Deserialize<List<Contact>>(ContactJson);
        if(string.IsNullOrWhiteSpace(ContactJson))
        {
            Console.WriteLine("No contacts to load!");
            return;
        }

        foreach (var contact in LoadContacts)
        {
            string prettyJson = JsonSerializer.Serialize(contact, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(prettyJson);
        }


    }
}
