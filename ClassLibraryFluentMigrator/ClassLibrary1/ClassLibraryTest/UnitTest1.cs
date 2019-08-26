using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UtilityLibraries;

namespace ClassLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DIrectTest()
        {
            bool result = true;
            try
            {
                ClassLibrary1.Initialization.Main();
            }
            catch (Exception)
            {
                result = false;

            }
            Assert.IsTrue(result,String.Format("Resultado: {0}", result));

           
        }
    }
}