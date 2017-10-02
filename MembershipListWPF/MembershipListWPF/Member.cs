using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipListWPF
{
    class Member 
    {
        private string firstName, lastName, email;

        public Member(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }


        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (firstName.Length > 25) firstName = value;
                else throw (new DivideByZeroException("No more than 25 characters please!"));
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName.Length > 25) lastName = value;
                else throw (new DivideByZeroException("No more than 25 characters please!"));
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (email.Length > 25) email = value;
                else throw (new DivideByZeroException("No more than 25 characters please!"));
            }
        }

        public string GetDisplayText()
        {
            return firstName + " " + lastName + " " + email;
        }
        
    }

    
}
