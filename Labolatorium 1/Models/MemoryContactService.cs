using System.Collections.Generic;
using System.Linq;

namespace Labolatorium_1.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _contacts = new();
        private int _nextId = 1;
        private readonly IDateTimeProvider _timeProvider;

        public MemoryContactService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public void AddContact(Contact contact)
        {
            contact.Id = _nextId++;
            contact.Created = _timeProvider.GetCurrentDateTime();
            _contacts.Add(contact.Id, contact);
        }

        public bool UpdateContact(Contact contact)
        {
            if (_contacts.ContainsKey(contact.Id))
            {
                _contacts[contact.Id] = contact;
                return true;
            }
            return false;
        }

        public bool DeleteContactById(int id)
        {
            return _contacts.Remove(id);
        }

        public Contact? GetContactById(int id)
        {
            return _contacts.ContainsKey(id) ? _contacts[id] : null;
        }

        public List<Contact> GetContacts()
        {
            return _contacts.Values.ToList();
        }
    }
}