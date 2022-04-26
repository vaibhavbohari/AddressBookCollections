using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCollections
{
    internal class Program
    {

        //Main  Method / program Entry Point
        static void Main(string[] args)
        {
            AddressBook createAddressBook = new AddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();


        }
    }
}