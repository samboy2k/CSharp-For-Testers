using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class C_MoreFixtureStuff
    {
        String message;

        //This method will be called before each test
        [SetUp]
        public void SetUp()
        {
            message = "I'm doing something to setup the test";
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
            message = "I'm a test number 1";
            TestContext.Progress.WriteLine(message);
        }

        [Test]
        public void TestTwo()
        {
            message = "I'm a test number 2";
            TestContext.Progress.WriteLine(message);
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            message = "I'm doing something to set up all the tests";
            TestContext.Progress.WriteLine(message);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            message = "I'm doing something to teardown all the tests";
            TestContext.Progress.WriteLine(message);
        }
    }
}