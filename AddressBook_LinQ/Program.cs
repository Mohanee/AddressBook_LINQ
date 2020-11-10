using System;

namespace AddressBook_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to AddressBook DataTable Using LinQ");
            Linq_Operations lopr = new Linq_Operations();
            lopr.CreateAddressBook();
        }
    }
}
