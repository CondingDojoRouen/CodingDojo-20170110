using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class KataPotterTests
    {
        [TestMethod]
        public void Returns0ifArrayIsEmpty()
        {
            //Arrange
            int[] books = new int[] { };
            //Act
            var result = KataPotter.GetPricing(books);
            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
