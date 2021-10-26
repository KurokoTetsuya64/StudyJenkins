using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JenkinsTest;

namespace JenkinsTestUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Animal animal = new Animal();
            int expectedNumber = 5;
            int number = animal.GetNumberOfLegs(expectedNumber);
            Assert.AreEqual(expectedNumber, number);

        }
    }
}
