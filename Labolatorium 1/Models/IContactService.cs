using System.Collections.Generic;

namespace Labolatorium_1.Models
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        bool UpdateContact(Contact contact);
        bool DeleteContactById(int id);
        Contact? GetContactById(int id);
        List<Contact> GetContacts();
    }
}