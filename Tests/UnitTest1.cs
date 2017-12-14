using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.Homepage.Goto();
            Assert.IsTrue(Pages.Homepage.IsAt());
        }
    }

    internal class Pages
    {
        public class Homepage
        {
            public static void Goto()
            {
                throw new NotImplementedException();
            }

            public static bool IsAt()
            {
                throw new NotImplementedException();
            }

        }


    }
}
