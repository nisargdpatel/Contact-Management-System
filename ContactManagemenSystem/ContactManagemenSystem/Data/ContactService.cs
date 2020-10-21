using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagemenSystem.Data
{
    public class ContactService
    {
        private readonly ContactDatabase contactDb;     //Object for database

        public ContactService(ContactDatabase givenDb)
        {
            //set the passed in database object to the local database object
            contactDb = givenDb;
        }


        //Precondition: None
        //Postcondition: returns list of contacts
        public List<Contact> getContact()
        {
            var listOfContacts = contactDb.Contacts.ToList();
            return listOfContacts;
        }


        //Precondition: Contact Object
        //Postcondition: adds given contact to database and returns success message
        public string Create(Contact newContact)
        {
            contactDb.Add(newContact);
            contactDb.SaveChanges();
            return "Contact Added Successfully";
        }


        //Precondition: Contact id
        //Postcondition: returns contact object given contact id
        public Contact getContact(int givenId)
        {
            //Stores the element found in database where givenId matches element's id
            Contact contact = contactDb.Contacts.FirstOrDefault(element => element.Id == givenId);
            return contact;
        }


        //Precondition: Contact object
        //Postcondition: updates a specific contact whose id matches given id and returns success message
        public string updateContact(Contact contact)
        {
            contactDb.Contacts.Update(contact);
            contactDb.SaveChanges();
            return "Contact Updated Successfully";
        }


        //Precondition: Contact object
        //Postcondition: deletes a specific contact whose id matches given id and returns success message
        public string DeleteContact(Contact contact)
        {
            contactDb.Remove(contact);
            contactDb.SaveChanges();
            return "Contact Removed Successfully";
        }
    }
}
