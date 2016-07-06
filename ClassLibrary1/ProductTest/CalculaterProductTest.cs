using CalculaterProduct;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product;
using System;
using System.Collections.Generic;

namespace ProductTest
{
    [TestClass]
    public class CalculaterProductTest
    {
        public List<Order> GetFakeData()
        {
            List<Order> FakeData = new List<Order>();

            FakeData.Add(new Order(1, 1, 11, 21));
            FakeData.Add(new Order(2, 2, 12, 22));
            FakeData.Add(new Order(3, 3, 13, 23));
            FakeData.Add(new Order(4, 4, 14, 24));
            FakeData.Add(new Order(5, 5, 15, 25));
            FakeData.Add(new Order(6, 6, 16, 26));
            FakeData.Add(new Order(7, 7, 17, 27));
            FakeData.Add(new Order(8, 8, 18, 28));
            FakeData.Add(new Order(9, 9, 19, 29));
            FakeData.Add(new Order(10, 10, 20, 30));
            FakeData.Add(new Order(11, 11, 21, 31));

            return FakeData;
        }

        [TestMethod]
        public void ProductCostCalculate()
        {
            //Arrange

            var SourceData = GetFakeData();
            int[] Expect = { 6, 15, 24, 21 };
            int[] Actual = { };
            int NumInGroup = 3;

            // Act
            Calculater Calculater = new Calculater();
            Actual = Calculater.CalculateSum(NumInGroup, SourceData, "_Id");

            //Assert
            CollectionAssert.AreEqual(Expect, Actual);
        }

        [TestMethod]
        public void ProductRevenueCalculate()
        {
            //Arrange
            var SourceData = GetFakeData();

            int[] Expect = { 50, 66, 60 };
            int[] Actual = { };
            int NumInGroup = 4;

            // Act
            Calculater Calculater = new Calculater();
            Actual = Calculater.CalculateSum(NumInGroup, SourceData, "_Revenue");

            //Assert
            CollectionAssert.AreEqual(Expect, Actual);
        }
    }
}