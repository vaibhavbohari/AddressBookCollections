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

            //Showing Welcome Message On console.
            Console.WriteLine("Welcome to Address Book Progam \n");

            AddressBook addressBook = new AddressBook();
            addressBook.AddContact();
            Console.ReadLine();


        }
    }
}