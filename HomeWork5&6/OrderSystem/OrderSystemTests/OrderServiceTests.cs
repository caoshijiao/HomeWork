using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        

        [TestMethod()]
        public void AddOrderTest1()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            Assert.AreEqual(service.AddOrder(order1), true);
        }
        [TestMethod()]
        public void AddOrderTest2()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            service.AddOrder(order1);
            Assert.AreEqual(service.AddOrder(order1), false);
        }
        [TestMethod()]
        public void AddOrderTest3()
        {
            var service = new OrderService();
            Assert.AreEqual(service.AddOrder(null), false);
        }

        [TestMethod()]
        public void DeleteOrderTest1()
        {
            var service = new OrderService();
            var order1 = new Order("X010101","101010");
            service.AddOrder(order1);
            Assert.AreEqual(service.DeleteOrder(order1), true);
        }
        [TestMethod()]
        public void DeleteOrderTest2()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            Assert.AreEqual(service.DeleteOrder(order1), false);
        }

        [TestMethod()]
        public void CheckOrderIDTest()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            var order2 = new Order("X102030", "134560");
            var orderItem1 = new OrderItem("bag", 2, 100);
            var orderItem2 = new OrderItem("hat", 1, 30);
            order1.AddOrderItem(orderItem1);
            order2.AddOrderItem(orderItem2);
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.CheckOrderID("X010101");
           
        }
       
        
        [TestMethod()]
        public void CheckOrderCardIDTest()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            var order2 = new Order("X102030", "134560");
            var orderItem1 = new OrderItem("bag", 2, 100);
            var orderItem2 = new OrderItem("hat", 1, 30);
            order1.AddOrderItem(orderItem1);
            order2.AddOrderItem(orderItem2);
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.CheckOrderCardID("101010");
        }

        [TestMethod()]
        public void AlertOrderTest1()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            var order2 = new Order("X010100", "101000");
            Assert.AreEqual(service.AlertOrder(order1,order2),false);

        }

        [TestMethod()]
        public void AlertOrderTest2()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            var order2 = new Order("X010100", "101000");
            service.AddOrder(order1);
            Assert.AreEqual(service.AlertOrder(order1, order2), true);

        }
        public void AlertOrderTest3()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            service.AddOrder(order1);
            Assert.AreEqual(service.AlertOrder(order1, null), false);

        }
        [TestMethod()]
        public void OrderSortTest()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            var order2 = new Order("X102030", "134560");
            var orderItem1 = new OrderItem("bag", 2, 100);
            var orderItem2 = new OrderItem("hat", 1, 30);
            order1.AddOrderItem(orderItem1);
            order2.AddOrderItem(orderItem2);
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.OrderSort();
        }

        [TestMethod()]
        public void ExportTest()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            var orderItem1 = new OrderItem("bag", 2, 100);
            order1.AddOrderItem(orderItem1);
            service.AddOrder(order1);
            service.Export("D:/order.xml");
        }

        [TestMethod()]
        public void ImportTest()
        {
            var service = new OrderService();
            var order1 = new Order("X010101", "101010");
            var orderItem1 = new OrderItem("bag", 2, 100);
            order1.AddOrderItem(orderItem1);
            service.AddOrder(order1);
            service.Export("D:/order.xml");
            service.DeleteOrder(order1);
            service.Import("D:/order.xml");
            service.OrderSort();
        }
    }
}