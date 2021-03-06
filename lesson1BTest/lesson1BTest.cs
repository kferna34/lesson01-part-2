﻿using System;
using week01_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace lesson1BTest
{
    /**
    *use to test the lesson 1 project
    *for dev purposes
    
    */
    [TestClass]
    public class lesson1BTest
    {
        [TestMethod]
        /*
        *test for outputStrignto console of the program class
        */
        public void OutputStringToConsoleTestMethod()
        {
            //arrange -- var
            string outputString ="Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult= "Enter UserName: ";

            //act--accessing method --fail
            actualResult =Program.OutputStringToConsole(outputString,hasNewLine);

            //assert --test
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
