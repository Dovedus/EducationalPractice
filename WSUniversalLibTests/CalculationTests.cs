using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest_CorrectData()
        {
            //arrange
            int productType = 3;
            int materialType = 1;
            int count = 15;
            int width = 20;
            int lenght = 45;
            int expected = 114146;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectProductType()
        {
            //arrange
            int productType = 50;
            int materialType = 1;
            int count = 15;
            int width = 20;
            int lenght = 45;
            int expected = -1;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectMaterialType()
        {
            //arrange
            int productType = 3;
            int materialType = 11;
            int count = 15;
            int width = 20;
            int lenght = 45;
            int expected = -1;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectProductType_MaterialType()
        {
            //arrange
            int productType = 50;
            int materialType = 90;
            int count = 15;
            int width = 20;
            int lenght = 45;
            int expected = -1;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectCount()
        {
            //arrange
            int productType = 3;
            int materialType = 1;
            int count = 5;
            int width = 20;
            int lenght = 45;
            int expected = 38049;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectCount_Lenght()
        {
            //arrange
            int productType = 3;
            int materialType = 1;
            int count = 5;
            int width = 20;
            int lenght = 14;
            int expected = 11837;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectCount_Widht()
        {
            //arrange
            int productType = 3;
            int materialType = 1;
            int count = 6;
            int width = 7;
            int lenght = 45;
            int expected = 15981;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectLenght_Widht()
        {
            //arrange
            int productType = 3;
            int materialType = 1;
            int count = 15;
            int width = 2;
            int lenght = 13;
            int expected = 3298;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectCount_Lenght_Widht()
        {
            //arrange
            int productType = 3;
            int materialType = 1;
            int count = 3;
            int width = 7;
            int lenght = 17;
            int expected = 3019;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectCount_MaterialType_ProductType()
        {
            //arrange
            int productType = -3;
            int materialType = 5;
            int count = 0;
            int width = 20;
            int lenght = 45;
            int expected = -1;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}