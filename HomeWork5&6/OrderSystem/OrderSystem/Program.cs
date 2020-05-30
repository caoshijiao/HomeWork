using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderItem order1_item1 = new OrderItem("bag", 2, 200);
            OrderItem order1_item2 = new OrderItem("socks", 3, 10);
            OrderItem order1_item3 = new OrderItem("pants", 2, 100);
            OrderItem order1_item4 = new OrderItem("shoes", 1, 105);
            OrderItem order1_item5 = new OrderItem("hat", 3, 15);



            OrderItem order2_item1 = new OrderItem("bag", 1, 200);
            OrderItem order2_item2 = new OrderItem("socks", 5, 10);
            OrderItem order2_item3 = new OrderItem("pants", 5, 100);
            OrderItem order2_item4 = new OrderItem("shoes", 2, 105);
            OrderItem order2_item5 = new OrderItem("hat", 3, 15);

            OrderItem order3_item1 = new OrderItem("bag", 3, 200);
            OrderItem order3_item2 = new OrderItem("socks", 5, 10);
            OrderItem order3_item3 = new OrderItem("pants", 4, 100);

            OrderItem order4_item1 = new OrderItem("bag", 3, 200);
            OrderItem order4_item2 = new OrderItem("socks", 5, 10);
            OrderItem order4_item3 = new OrderItem("pants", 4, 100);


            Order order1 = new Order("X010101", "000001");
            Order order2 = new Order("X001100", "000001");
            Order order3 = new Order("X001101", "000002");
            Order order4 = new Order("X001103", "000004");

            order1.AddOrderItem(order1_item1);
            order1.AddOrderItem(order1_item1);
            order1.AddOrderItem(order1_item2);
            order1.AddOrderItem(order1_item3);
            order1.AddOrderItem(order1_item4);
            order1.AddOrderItem(order1_item5);

            order2.AddOrderItem(order2_item1);
            order2.AddOrderItem(order2_item2);
            order2.AddOrderItem(order2_item3);
            order2.AddOrderItem(order2_item4);
            order2.AddOrderItem(order2_item5);

            order3.AddOrderItem(order3_item1);
            order3.AddOrderItem(order3_item2);
            order3.AddOrderItem(order3_item3);

            order4.AddOrderItem(order4_item1);
            order4.AddOrderItem(order4_item2);
            order4.AddOrderItem(order4_item3);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            Console.WriteLine();
            Console.WriteLine("订单添加后排序：");
            orderService.OrderSort();
            Console.WriteLine();
            Console.WriteLine("订单查询：");
            orderService.CheckOrderID("X010101");
            Console.WriteLine();
            Console.WriteLine("订单查询：");
            orderService.CheckOrderCardID("000001");

            Console.WriteLine();
            Console.WriteLine("订单修改后排序：");
            orderService.AlertOrder(order1, order3);
            orderService.OrderSort();
            Console.WriteLine();
            Console.WriteLine("订单修改：");
            orderService.AlertOrder(order4, order1);

            Console.WriteLine();
            Console.WriteLine("订单删除后排序：");
            orderService.DeleteOrder(order2);
            orderService.OrderSort();
            Console.WriteLine();
            Console.WriteLine("订单删除：");
            orderService.DeleteOrder(order4);


            orderService.Export("D:/order.xml");
            Console.WriteLine();
            orderService.DeleteOrder(order1);
            orderService.DeleteOrder(order2);
            Console.WriteLine();
            orderService.OrderSort();
            Console.WriteLine();
            orderService.Import("D:/order.xml");
            Console.WriteLine();
            orderService.OrderSort();








        }
    }
}
