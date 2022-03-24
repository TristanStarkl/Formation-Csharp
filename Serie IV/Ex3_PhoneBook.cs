using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class PhoneBook
    {
        private Dictionary<string, string> _listContacts;

        public PhoneBook()
        {
            this._listContacts = new Dictionary<string, string>();
        }


        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 10)
                return false;
            if (phoneNumber[0] != '0' || phoneNumber[1] =='0')
                return false;
            return true;
        }

        public bool ContainsPhoneContact(string phoneNumber)
        {
            try
            {
                string tmp = this._listContacts[phoneNumber];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void PhoneContact(string phoneNumber)
        {
            if (!this.ContainsPhoneContact(phoneNumber))
                throw new Exception("Erreur le numéro de téléphone n'est pas répertorié.");
            Console.WriteLine($"{phoneNumber} : {this._listContacts[phoneNumber]}");
        }

        public bool AddPhoneNumber(string phoneNumber, string name)
        {
            if (!this.IsValidPhoneNumber(phoneNumber))
                return false;
            if (this.ContainsPhoneContact(phoneNumber))
                return false;
            if (name.Length == 0)
                return false;
            this._listContacts.Add(phoneNumber, name);
            return true;
        }

        public bool DeletePhoneNumber(string phoneNumber)
        {
            if (!this.ContainsPhoneContact(phoneNumber))
                throw new Exception("Erreur le numéro de téléphone n'est pas répertorié.");
            this._listContacts.Remove(phoneNumber);
            return true;
        }

        public void DisplayPhoneBook()
        {
            Console.WriteLine("Annuaire téléphonique :");
            Console.WriteLine("-----------------------");
            foreach (KeyValuePair<string, string> kvp in this._listContacts)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
            Console.WriteLine("-----------------------");
        }
    }
}
