/*9. Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.*/

/*10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.*/

/*11. Add a method that calculates the total price of the calls in the call history. 
 * Assume the price per minute is fixed and is provided as a parameter.*/

namespace _07.CreateGSMTest
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    
    public class GSM
    {
        ////Added in exercise 11
        //private const double pricePerMinute = 0.33;
        
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        //Added in exercise 6
        private static string iPhone4S;
        //Added in exercise 10
        private Call callHistory;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double? price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double? price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public double? Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public string IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        Battery newBattery = new Battery("Li-Ion 3100 mAh", 980, 35, BatteryType.LiIon);

        Display newDisplay = new Display(5.55, 16000000);

        //STANDARD WAY
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("Model: " + this.Model);
        //    sb.AppendLine("Manufacturer: " + this.Manufacturer);
        //    sb.AppendLine("Price: " + this.Price + "lv");
        //    sb.AppendLine("Owner: " + this.Owner);
        //    sb.AppendLine("Battery model: " + newBattery.Model);
        //    sb.AppendLine("Battery type: " + newBattery.Type);
        //    sb.AppendLine("Hours idle: " + newBattery.HoursIdle);
        //    sb.AppendLine("Hours talk: " + newBattery.HoursTalk);
        //    sb.AppendLine("Display size: " + newDisplay.Size);
        //    sb.AppendLine("Display colors: " + newDisplay.NumberOfColors);

        //    return sb.ToString();
        //}

        //REFLECTION
        public override string ToString()
        {
            var result = new StringBuilder();

            var properties = this.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.GetValue(this, null) != null)
                {
                    result.AppendFormat("{0}: {1}; ", property.Name, property.GetValue(this, null));    
                }
            }

            return result.ToString();
        }

        //Start Exercise 10
        public List<Call> callsList = new List<Call>();

        public void AddCallInHistory(string currCallDate, TimeSpan currCallTime, uint currDialedPhoneNumber, uint currCallDuration)
        {
            callHistory = new Call(currCallDate, currCallTime, currDialedPhoneNumber, currCallDuration);
            callsList.Add(callHistory);
        }

        public void DeleteCallFromHistoryByNumber(uint dialedNumber)
        {
            callHistory.dialedPhoneNumber = dialedNumber;

            int index = -1;
            int indexCounter = 0;

            foreach (var call in callsList)
            {
                if (call.dialedPhoneNumber == dialedNumber)
                {
                    index = indexCounter;
                    break;
                }
                else
                {
                    indexCounter++;
                }
            }

            if (index != -1)
            {
                callsList.RemoveAt(index);
            }
        }

        public void ClearCallHistory()
        {
            callsList.Clear();
        }

        //End Exercise 10

        //Start Exercise 11

        public void CalculatePriceOfAllCalls(double pricePerMinute)
        {
            double sum = 0;

            foreach (var call in callsList)
            {
                double duration = call.callDuration;
                sum += (duration / 60) * pricePerMinute;    
            }

            Console.WriteLine("=====================PRICE===================");
            Console.WriteLine("The price of all calls in calls history is {0}", sum);
            Console.WriteLine("=============================================");
        }

        //End Exercise 11

        //Start Exercise 12

        public void DeleteLongestCall()
        {
            uint longestCall = 0;
            int index = 0;

            //Get the longest call
            foreach (var call in callsList)
            {   
                if (longestCall < call.callDuration)
                {
                    longestCall = call.callDuration;
                }
            }

            //Get the index of the longest call
            foreach (var call in callsList)
            {
                if (call.callDuration == longestCall)
                {
                    break;
                }
                else
                {
                    index++;
                }
            }

            //Remove the longest call
            callsList.RemoveAt(index);
        }

        public void PrintCallHistoryList()
        {
            foreach (var call in callsList)
            {
                Console.WriteLine("======================CALL=====================");
                Console.WriteLine(call.callDate + ", " + call.callTime + ", " + call.dialedPhoneNumber + ", " + call.callDuration);
                Console.WriteLine("================================================");
            }
        }

        //End Exercise 12
    }
}
