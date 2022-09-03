using System;

namespace ProgChallenge
{
    public class BankAccount {
        private string _firstname;
        private string _lastname;

        public decimal Balance {
            get; set;
        }

        public BankAccount(string fname, string lname, decimal initial=0.0m) {
            _firstname = fname;
            _lastname = lname;
            Balance = initial;
        }

        public string AccountOwner {
            get => $"{_firstname} {_lastname}";
        }

        public virtual void Deposit(decimal amount) {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount) {
            Balance -= amount;
        }
    }
}
