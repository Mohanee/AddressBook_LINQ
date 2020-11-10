using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_LinQ
{
   
        public class ContactException : Exception
        {
            public enum error { Invalid_Name, Invalid_Email, Invalid_Zipcode, Invalid_Mobile, Invalid_Address, Invalid_CityState };

            public error errorType;

            public ContactException(error error, string message) : base(message)
            {
                errorType = error;
            }
        }
}
