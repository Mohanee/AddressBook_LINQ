using System;

namespace AddressBook_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to AddressBook DataTable Using LinQ");
            Linq_Operations lopr = new Linq_Operations();

            //UC1&2(CreateAddressBook)
             lopr.CreateAddressBook();

            //UC3(InsertValues)
            lopr.InsertValues();
            lopr.DisplayDataTable();

            //UC4(EditContact)
          /*  lopr.EditExistingContact();
            lopr.DisplayDataTable();*/
        }
    }
}
