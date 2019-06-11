//Running Code

//Terminal > New Terminal
//type 'dotnet run'
//What is causing this code to execute?

using System;

namespace CSharp_For_Testers
{
    public class E_RunningCode
    {
        public static String middleName = "Stephen";
        public int age = 33;

        public void PersonalDetails()
        {
            Person instructor = new Person("Richard", middleName, "Bradshaw", 33);
            Console.WriteLine(instructor.CompleteName());
            Console.WriteLine("{0} was born in {1}", instructor.GetFirstName(), instructor.CalculateAge());

            if(age > 18)
            {
                Console.WriteLine("Old enough to drink in the UK");
            }
            else
            {
                Console.WriteLine("Not old enough to drink in the UK");
            }
        }
    }
}