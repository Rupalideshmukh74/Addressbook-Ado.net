using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_System_db
{
   public  class Addressbook
    {
        List<PersonModel> People;

        public Addressbook()
        {
            People = new List<PersonModel>();
        }
    }
}
