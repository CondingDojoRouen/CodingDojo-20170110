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

        [TestMethod]
        public void Returns16IfContainsOnly2SameBooks()
        {
            //Arrange
            int[] books = new int[] { 1, 1 };
            int[] books2 = new int[] { 1, 2 };
            //Act
            var result = KataPotter.GetPricing(books);
            var result2 = KataPotter.GetPricing(books2);
            //Assert
            Assert.AreEqual(16, result);
            Assert.AreNotEqual(16, result2);
        }

        [TestMethod]
        public void ThrowArgumentOutOfRangeExceptionIfArrayContainsElementsIdGreaterThan5()
        {
            //Arrange
            int[] books = new int[] { 1, 2, 6, 6 };
            //Act
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => KataPotter.GetPricing(books));
        }

        [TestMethod]
        public void ThrowArgumentOutOfRangeExceptionIfArrayContainsElementsIdLowerThan1()
        {
            // Arrange
            int[] books = new int[] { -9825, 4, 2 };
            int[] books2 = new int[] { -9825 };
            int[] books3 = new int[] { 12, 0 };

            // Act
            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => KataPotter.GetPricing(books));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => KataPotter.GetPricing(books2));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => KataPotter.GetPricing(books3));
        }

        [TestMethod]
        public void Returns0IfArrayIsEmpty()
        {
            //Arrange
            var books = new int[] { };
            //Act
            var result = KataPotter.GetPricing(books);
            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Returns24IfArrayContains3Books1()
        {
            //Arrange
            var books = new int[] { 1, 1, 1 };
            //Act
            var result = KataPotter.GetPricing(books);
            //Assert
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void Returns5PercentDiscountFor2DifferentBooks()
        {
            //Arrange
            var books = new int[] { 1, 5 };
            //Act
            var result = KataPotter.GetPricing(books);
            //Assert
            Assert.AreEqual(16 * 0.95, result);
        }

        [TestMethod]
        public void Return10PercentDiscountFor3DifferentBooks()
        {
            //Arrange
            var books = new int[] { 1, 2, 3 };
            //Act
            var result = KataPotter.GetPricing(books);

            //Assert
            Assert.AreEqual(24 * 0.90, result);

        }

        [TestMethod]
        public void Return20PercentDiscountFor4DifferentBooks()
        {
            //Arrange
            var books = new int[] { 1, 2, 3, 4 };
            //Act
            var result = KataPotter.GetPricing(books);

            //Assert
            Assert.AreEqual(32 * 0.80, result);

        }

        [TestMethod]
        public void Return25PercentDiscountFor5DifferentBooks()
        {
            //Arrange
            var books = new int[] { 1, 2, 3, 4, 5 };
            //Act
            var result = KataPotter.GetPricing(books);

            //Assert
            Assert.AreEqual(40 * 0.75, result);

        }

        [TestMethod]
        public void Return23dot2IfArrayContains3BooksWith2SimilarBooks()
        {
            //Arrange
            var books = new int[] { 1, 2, 2 };
            //Act
            var result = KataPotter.GetPricing(books);

            //Assert
            Assert.AreEqual(23.2, result);
        }

        //[TestMethod]
        //public void Return30dot4IfArrayContains4BooksWith2Times2SimilarBooks()
        //{
        //    //Arrange
        //    var books = new int[] { 1, 1, 2, 2 };
        //    //Act
        //    var result = KataPotter.GetPricing(books);

        //    //Assert
        //    Assert.AreEqual(30.4, result);
        //}
    }
}
