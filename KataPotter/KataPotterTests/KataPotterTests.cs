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

        [TestMethod]
        public void ThrowArgumentNullExceptionIfParamIsNull()
        {
            //Arrange            
            //Act
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => KataPotter.GetPricing(null));
        }

        [TestMethod]
        public void Returns8ifArrayContains1Element()
        {
            //Arrange
            int[] books = new int[] { 1 };
            //Act
            var result = KataPotter.GetPricing(books);
            //Assert
            Assert.AreEqual(8, result);

        }
    }
}
