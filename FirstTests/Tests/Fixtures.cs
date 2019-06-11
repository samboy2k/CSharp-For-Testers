using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class B_CreatingATestFixture
    {
        String message;

        //This method will be called before each test
        [SetUp]
        public void SetUp()
        {
            message = "I'm doing something to setup the system ready for the test";
            //"TestContext.Progress.WriteLine" this is the same as Console.WriteLine however the test will do the outputting in real test time, instead of .NET
            TestContext.Progress.WriteLine(message);
        }

        //This method will be called after each test
        [TearDown]
        public void Teardown()
        {
            message = "I'm doing something to tidy up after the test";
            TestContext.Progress.WriteLine(message);
        }

        [Test]
        public void TestOne()
        {
            message = "I'm a test doing some stuff";
            TestContext.Progress.WriteLine(message);
        }
    }
}