using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAnts
{
    [TestClass]
    public class DeadAntsKataTest
    {
        private readonly DeadAntsKata _kata = new DeadAntsKata();

        [TestMethod]
        public void All_alive_ants_return_0()
        {
            var actual = _kata.GetDeadAntsCount("ant ant ant ant");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void One_dead_ant_only_head_return_1()
        {
            var actual = _kata.GetDeadAntsCount("a ant ant ant");

            Assert.AreEqual(1, actual);
        }
    }
}