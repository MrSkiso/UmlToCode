using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace UmlToCode
{

    struct Address
    {
        public string Street;
        public string City;
        public string State;
        public int PostalCode;
        public string Country;

        public bool Validate()
        {
            return true;
        }

    }

    public abstract class Person
    {
        public int ID;
        public string Name;
        public string Phone;
        public string Email;
        public Address address;

    }

    public class Customer : Person
    {
        public DateTime Registration;
        private int CreditScore;
        public List<Account> Accounts;

    }

    public class Employee : Person
    {
        public enum Department { };
        private float Salary;
    }

    public class Account
    {
        public string IBAN;
        private float Amount;
        public Transaction transactions;

        public bool Transaction(string path)
        {
            return true;
        }
    }

    public class Investing : Account
    {
        public float Interest;

        protected bool ApllyInterest()
        {
            return true;
        }
    }

    public class Savings : Account
    {
        private float ProtectedAmount;

        protected bool LiberateSavings()
        {
            return true;
        }
    }

    struct Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Request;
        
    }
}


