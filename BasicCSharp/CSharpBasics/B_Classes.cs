//https://automationintesting.com/programming/lessons/classesandobjects
//A class is a template of an Object, like a blueprint
//An Object is an instance of a class
using NUnit.Framework;

namespace CSharpBasics
{
    public class B_Classes
    {
        [Test]
        public void CreateAnObject()
        {
            Car RichardsCar = new Car("Ford", "Focus", 1400);
            Assert.That(RichardsCar.GetCarModel, Is.EqualTo("Ford"));
        }
    }

    public class Car
    {
        public string manufacturer;
        public string model;

        public int enginecc;

        public Car(string manufacturer, string model, int enginecc)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.enginecc = enginecc;
        }

        public string GetCarModel()
        {
            return model;
        }
    }
}