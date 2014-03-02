/*7. Write a class GSMTest to test the GSM class:
 * Create an array of few instances of the GSM class.
 * Display the information about the GSMs in the array.
 * Display the information about the static property IPhone4S.
*/

namespace _07.CreateGSMTest
{
    using System;
    using System.Collections.Generic;
    
    public class GSMTest
    {
        private List<GSM> GsmList = new List<GSM>();

        private string[] models = { "Galaxy Note 2", "S4", "One" };
        private string[] manufacturers = { "Samsung", "Samsung", "HTC" };
        private double[] prices = { 1030.00, 1299.90, 1179.00 };
        private string[] owners = { "Pesho", "Dragan", "Ivan" };

        public void AddGsmInTheList()
        {
            for (int i = 0; i < models.Length; i++)
            {
                GSM newGSM = new GSM(models[i], manufacturers[i], prices[i], owners[i]);
                GsmList.Add(newGSM);
            }
        }

        public void PrintAllGSMs()
        {
            foreach (var gsm in GsmList)
            {
                //Console.Write(gsm.Model + ", ");
                //Console.Write(gsm.Manufacturer + ", ");
                //Console.Write(gsm.Price + ", ");
                //Console.Write(gsm.Owner);
                //Console.WriteLine();

                //Using override ToString method with Reflection
                Console.WriteLine(gsm.ToString());
            }
        }
    }
}
