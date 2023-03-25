using Microsoft.VisualStudio.TestTools.UnitTesting;
using order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        List<Goods> goods1;
        List<Goods> goods2;
        List<Goods> goods3;
        OrderService orderService;
        Order order1, order2, order3;
       
    [TestInitialize]
       public void Initialize()
        {
            goods1 = new List<Goods>(2)
            {
                new Goods("fruits", 10, 1),
                new Goods("vegetables", 2, 3)
            };
           goods2 = new List<Goods>(2)
            {
                new Goods("planets", 100, 50),
                new Goods("flowers", 20, 30)
            };
           goods3 = new List<Goods>(3)
            {
                new Goods("fruits",20,2),
                new Goods("planets",20,60),
                new Goods("juice",100,3)
            };

            orderService = new OrderService();
            order1 = new Order(1, goods1, new Clients("张三"), 100);
            order2 = new Order(2, goods2, new Clients("李四"), 500);
            order3 = new Order(3, goods3, new Clients("王五"), 100);
        }
       [TestMethod()]
        //正常情况检测
        public void AddOrderTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            //Test
            orderService.AddOrder(order2);
            OrderService result = new OrderService();
            result.Orders.Add(order1);
            result.Orders.Add(order2);
            //Assert
            Assert.AreEqual(orderService, result);
        }
        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]

        //已存在需要添加的订单
        public void AddOrderTest2()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            //Test
            orderService.AddOrder(order2);
            OrderService result = new OrderService();
            result.Orders.Add(order1);
            result.Orders.Add(order2);
            //Assert
          //  Assert.AreEqual(orderService, result);
        }

        [TestMethod()]
        //正常情况
        public void DeleteOrderTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            //Test
            orderService.DeleteOrder(order2);
            OrderService result = new OrderService();
            result.Orders.Add(order1);
            //Assert
            Assert.AreEqual(orderService, result);
        }
        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        //删除不存在的订单
        public void DeleteOrderTest2()
        {
            //Arrange
            orderService.Orders.Add(order1);
            //Test
            orderService.DeleteOrder(order2);
            OrderService result = new OrderService();
            result.Orders.Add(order1);
            //Assert
          //  Assert.AreEqual(orderService, result);
        }

        [TestMethod()]
        //正常情况
        public void UpdateOrderTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            //Test
            orderService.UpdateOrder(order2, order3);
            OrderService result = new OrderService();
            result.Orders.Add(order1);
            result.Orders.Add(order3);
            //Assert
            Assert.AreEqual(orderService, result);
        }
        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        //替换不存在的订单
        public void UpdateOrderTest2()
        {
            //Arrange
            orderService.Orders.Add(order1);
            //Test
            orderService.UpdateOrder(order2, order3);
            //OrderService result = new OrderService();
            //result.Orders.Add(order1);
            //Assert
           // Assert.AreEqual(orderService, result);
        }

        //存在
        [TestMethod()]
        public void IsExistTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            orderService.Orders.Add(order3);
            //Test
            bool test=orderService.IsExist(order2);
            bool result = true;
            //Assert
            Assert.AreEqual(test,result);
        }
        //不存在
        [TestMethod()]
        public void IsExistTest2()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            //Test
            bool test = orderService.IsExist(order3);
            bool result = false;
            //Assert
            Assert.AreEqual(test, result);
        }
        //存在
        [TestMethod()]
        public void SearchIndexTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            orderService.Orders.Add(order3);
            //Test
            int test = orderService.SearchIndex(order3);
            int result = 2;
            //Assert
            Assert.AreEqual(test, result);
        }
        //不存在
        [TestMethod()]
        public void SearchIndexTest2()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            //Test
            int test = orderService.SearchIndex(order3);
            int result = -1;
            Assert.AreEqual(test, result);
        }
        //存在该订单
        [TestMethod()]
        public void SearchNumTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            orderService.Orders.Add(order3);
            //Test
            List<Order> test = orderService.SearchNum(order1.OrderNum);
            List<Order> result = new List<Order>() { order1 };
            //Assert
            CollectionAssert.AreEqual(test, result);
        }
        //不存在该订单
        [TestMethod()]
        public void SearchNumTest2()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            //Test
            List<Order> test = orderService.SearchNum(order3.OrderNum);
            List<Order> result = new List<Order>() { };
            //Assert
            CollectionAssert.AreEqual(test, result);
        }

        [TestMethod()]
        //存在该订单
        public void SearchGoodsTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            orderService.Orders.Add(order3);
            //Test
            List<Order> test = orderService.SearchGoods(order1.Details.goods);
            List<Order> result = new List<Order>() { order1 };
            //Assert
            CollectionAssert.AreEqual(test, result);
        }
        //不存在该订单
        [TestMethod()]
        public void SearchGoodsTest2()
        { 
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            //Test
            List<Order> test = orderService.SearchGoods(order3.Details.goods);
            List<Order> result = new List<Order>() { };
            //Assert
            CollectionAssert.AreEqual(test, result);
        }
        //存在该订单
        [TestMethod()]
        public void SearchClientTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            orderService.Orders.Add(order3);
            //Test
            List<Order> test = orderService.SearchClient(order1.Client);
            List<Order> result = new List<Order>() { order1 };
            //Assert
            CollectionAssert.AreEqual(test, result);
        }
        //不存在该订单
        [TestMethod()]
        public void SearchClientTest2()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            //Test
            List<Order> test = orderService.SearchClient(order3.Client);
            List<Order> result = new List<Order>() { };
            //Assert
            CollectionAssert.AreEqual(test, result);
        }

        //存在该订单
        [TestMethod()]
        public void SearchAmountTest1()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            orderService.Orders.Add(order3);
            //Test
            List<Order> test = orderService.SearchAmount(order1.Details.Amount);
            List<Order> result = new List<Order>() { order1,order3 };
            //Assert
            CollectionAssert.AreEqual(test, result);
        }
        //不存在该订单
        [TestMethod()]
        public void SearchAmountTest2()
        {
            //Arrange
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order3);
            //Test
            List<Order> test = orderService.SearchNum(order2.OrderNum);
            List<Order> result = new List<Order>() { };
            //Assert
            CollectionAssert.AreEqual(test, result);
        }
        [TestMethod()]
        public void SortTest()
        {
            //Arrange
            orderService.AddOrder(order2);
            orderService.AddOrder(order1);
            orderService.AddOrder(order3);
            //Test
            orderService.Sort();
            OrderService result = new OrderService();
            result.Orders.Add(order1);
            result.Orders.Add(order2);
            result.Orders.Add(order3);
            //Assert
            Assert.AreEqual(orderService, result);
        }

    }
}