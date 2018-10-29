using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401Assignment
{
    public class Customer
    {
        //Class Variables go here

        private static int versionNumber;
        //Instance variables go here
        private string customerName;
        private string customerAddress;
        private int customerZip;
        //constructor method goes here

        public Customer()
        {
            Console.WriteLine("Customer Object Granted");
        }
        //class methods go here
        public static int GetVersionNumber()
        {
            return versionNumber;
        }
        public static void SetVersionNumber(int newVersionNumber)
        {
            versionNumber = newVersionNumber;
        }
        //instance methods go here
        public string getCustomerName()
        {
            return customerName;
        }

        public void setCustomerName(string newName)
        {
            customerName = newName;
        }

        //retrieve customer Address
        public string getCustomerAddress()
        {
            return customerAddress;
        }

        //set the customer address
        public void setCustomerAddress(string newAddress)
        {
            customerAddress = newAddress;
        }

        //retrieve the customer zip
        public int getCustomerZip()
        {
            return customerZip;
        }

        //set the customer izp
        public void setCustomerZip(int newZip)
        {
            customerZip = newZip;
        }
    }//end of customer class definition
}
