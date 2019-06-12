//HotSeat
//Someone will be volunteering to walk us through this code
//The audience can help, but only when asked by the person in the hotseat


//Label each line of code with what's happening

using System;

namespace CSharp_For_Testers
{
    public class E_LabellingCode
    {
        public double hourlyPay;
        public double overTimeRate;
        public double overTimeLimit;

        public E_LabellingCode()
        {
            this.hourlyPay = 10.0;
            this.overTimeRate = 1.5;
            this.overTimeLimit = 40;
        }

        public double caculateBasePay(double hoursWorks)
        {
            if (hoursWorks > overTimeLimit)
            {
                double overTimeHours = hoursWorks - overTimeLimit;
                double overTimeHoursAtRate = overTimeHours * overTimeRate;
                double totalHours = overTimeLimit + overTimeHoursAtRate;
                return totalHours * hourlyPay;
            }
            return hourlyPay * hoursWorks;
        }
    }
}