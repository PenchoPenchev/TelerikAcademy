/*8. Create a class Call to hold a call performed through a GSM. 
 * It should contain date, time, dialed phone number and duration (in seconds).*/

namespace _07.CreateGSMTest
{
    using System;
    using System.Collections.Generic;

    public class Call
    {
        public string callDate { get; set; }
        public TimeSpan callTime { get; set; }
        public uint dialedPhoneNumber { get; set; }
        public uint callDuration { get; set; }

        public Call()
        {

        }

        public Call(string callDate, TimeSpan callTime, uint dialedPhoneNumber, uint duration)
        {
            this.callDate = callDate;
            this.callTime = callTime;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.callDuration = duration;
        }

    }
}
