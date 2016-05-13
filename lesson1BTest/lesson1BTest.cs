using System;
using week01_02
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace lesson1BTest
{
    [TestClass]
    public class lesson1BTest
    {
        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            //arrange -- var
            string outputString ="Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult= "Enter Name:";

            //act--accessing method --fail
            actualResult =Program.OutputStringToConsole(outputString,hasNewLine);

            //assert --test
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
