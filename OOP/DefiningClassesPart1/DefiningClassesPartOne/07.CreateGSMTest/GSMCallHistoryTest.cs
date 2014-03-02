/*12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
 * Create an instance of the GSM class.
 * Add few calls.
 * Display the information about the calls.
 * Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
 * Remove the longest call from the history and calculate the total price again.
 * Finally clear the call history and print it. */

namespace _07.CreateGSMTest
{
    using System;
    using System.Collections.Generic;
    
    class GSMCallHistoryTest
    {
        public void TestGSMCallHistory()
        {
            GSM gsm = new GSM("Note 2", "Samsung");

            gsm.AddCallInHistory(DateTime.Now.Date.ToShortDateString(), DateTime.Now.TimeOfDay, 0883123321, 15);
            gsm.AddCallInHistory(DateTime.Now.Date.ToShortDateString(), DateTime.Now.TimeOfDay + TimeSpan.FromHours(1), 0884123321, 43);
            gsm.AddCallInHistory(DateTime.Now.Date.ToShortDateString(), DateTime.Now.TimeOfDay + TimeSpan.FromHours(1.5), 0885123321, 250);

            gsm.PrintCallHistoryList();

            gsm.CalculatePriceOfAllCalls(0.37);

            gsm.DeleteLongestCall();

            gsm.PrintCallHistoryList();

            gsm.CalculatePriceOfAllCalls(0.37);
        }
        
    }
}
