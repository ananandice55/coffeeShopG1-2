using System;
using System.Text;
using System.Collections.Generic;
using Coffee;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unittest
{
    [TestClass]
    public class UnitTestProduct
    {
        FormShop fs = new FormShop();

        [TestMethod]
        public void testEmptyProuct()
        {
            bool check = fs.checkEmptyProduct(0);
            Assert.IsFalse(check);
        }

        [TestMethod]
        public void testNotEmptyProuct()
        {
            bool check = fs.checkEmptyProduct(10);
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void testEmptyDiscount()
        {
            bool check = fs.checkEmptyDiscount("0");
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void testNotEmptyDiscount()
        {
            bool check = fs.checkEmptyDiscount("20");
            Assert.IsFalse(check);
        }
    }
}
