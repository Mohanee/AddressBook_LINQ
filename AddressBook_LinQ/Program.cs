﻿using System;

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
            Console.WriteLine("Insertion of Contacts");
            lopr.InsertValues();
            lopr.DisplayDataTable();
            Console.WriteLine("\n\n\n");

            //UC4(EditContact)
            Console.WriteLine("Editing a contact");
            lopr.EditExistingContact();
            Console.WriteLine("\n\n\n");

            //UC5(DeleteContact)
            Console.WriteLine("Deleting a contact");
            lopr.DeleteContact("Sweta");
            lopr.DisplayDataTable();
            Console.WriteLine("\n\n\n");
        }
    }
}
