//HotSeat
//Someone will be volunteering to walk us through this code
//The audience can help, but only when asked by the person in the hotseat



//TODO IMPROVE THIS

using System;

namespace CSharp_For_Testers
{
    public class D_ReadingCode
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

    public class Person
    {
            private String FirstName;
            private String MiddleName;
            private String Surname;
            private int Age;

        public Person(String firstName, String middleName, String surname, int age)
        {
            FirstName = firstName;
            MiddleName = middleName;
            Surname = surname;
            Age = age;
        }

        public String CompleteName()
        {
            return String.Format("{0} {1} {2}", FirstName, MiddleName, Surname); 
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - Age;
        }

        public String GetFirstName()
        {
            return FirstName;
        }
    }
}   

/*
    Writing code is very different from reading code.
    We can learn a lot by reading the code of others, it's great way to find new patterns
    GitHub is a great place to practice reading code
 */