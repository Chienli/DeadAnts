using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAnts
{
    [TestClass]
    public class DeadAntsKataTest
    {
        [TestMethod]
        public void All_alive_ants_return_0()
        {
            //arrange
            var kata = new DeadAntsKata();

            //act
            var actual = kata.GetDeadAntsCount("ant ant ant ant");

            //assert
            Assert.AreEqual(0, actual);
        }
    }
}