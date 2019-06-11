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
            private String _firstName;
            private String _middleName;
            private String _surname;
            private int _age;

        public Person(String firstName, String middleName, String surname, int age)
        {
            _firstName = firstName;
            _middleName = middleName;
            _surname = surname;
            _age = age;
        }

        public String CompleteName()
        {
            return String.Format("{0} {1} {2}", _firstName, _middleName, _surname); 
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - _age;
        }

        public String GetFirstName()
        {
            return _firstName;
        }
    }
}   

/*
    Writing code is very different from reading code.
    We can learn a lot by reading the code of others, it's great way to find new patterns
    GitHub is a great place to practice reading code
 */