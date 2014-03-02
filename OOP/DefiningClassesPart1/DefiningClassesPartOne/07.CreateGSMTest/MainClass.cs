/*7. Write a class GSMTest to test the GSM class:
 * Create an array of few instances of the GSM class.
 * Display the information about the GSMs in the array.
 * Display the information about the static property IPhone4S.
*/

/*9. Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.*/

/*10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.*/

/*11. Add a method that calculates the total price of the calls in the call history. 
 * Assume the price per minute is fixed and is provided as a parameter.*/

namespace _07.CreateGSMTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class MainClass
    {
        static void Main()
        {   
            GSMTest gsmTest = new GSMTest();
            gsmTest.AddGsmInTheList();
            gsmTest.PrintAllGSMs();

            GSMCallHistoryTest test = new GSMCallHistoryTest();
            test.TestGSMCallHistory();
        }
    }
}
