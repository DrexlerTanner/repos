using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Customer Console application
namespace _401Assignment
{
    class CustomerTest
    {//main method
        static void Main(string[] args)
        {
            //Create a Customer Object
            Customer myCustObj = new Customer();

            //set Customer version number
            Customer.SetVersionNumber(1);

            //display the CUstomer version number
            Console.WriteLine();
            Console.WriteLine("Here's the new address: " + Customer.GetVersionNumber());

            myCustObj.setCustomerAddress("123 lane wayyyy");
            myCustObj.setCustomerName("Bad Boy Rick");
            myCustObj.setCustomerZip(12345);

            Console.WriteLine("Here's the new address: " + myCustObj.getCustomerAddress());
            Console.WriteLine("Name: " + myCustObj.getCustomerName());
            //the DOS Display Window
            Console.WriteLine();
            Console.WriteLine("The version number is " + Customer.GetVersionNumber());
            Console.ReadLine();
        }//end main method

    }//End CustomerTest class definition
}
