using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderSystem
{
    public class OrderService
    {
        List<Order> OrderList = new List<Order>();
        public OrderService()
        {

        }
        public bool AddOrder(Order order)
        {
            if (order == null)
            {
                return false;
            }
            else
            {
                if (!(OrderList.Contains(order)))
                {
                    OrderList.Add(order);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

        }
        public bool DeleteOrder(Order order)
        {
            if (!(OrderList.Remove(order)))
            {
                Console.WriteLine("Order does not exist!");
                return false;
            }
            else
            {
                return true;
            }

        }
        public void CheckOrderID(String ID)
        {
            var query = from order in OrderList
                        where order.ID == ID
                        select order;
            foreach (var x in query)
            {
                Console.WriteLine(x.ToString());
            }
        }
        public void CheckOrderCardID(String CardID)
        {
            var query = from order in OrderList
                        where order.CardID == CardID
                        orderby order.OrderPrice
                        select order;
            foreach (var x in query)
            {
                Console.WriteLine(x.ToString());
            }


        }
        public bool AlertOrder(Order wrong, Order right)
        {
            if (wrong == null || right == null)
            {
                return false;
            }
            else
            {
                if (OrderList.Remove(wrong))
                {
                    OrderList.Add(right);
                    return true;
                }
                else
                {
                    Console.WriteLine("Order does not exist!");
                    return false;
                }
            }
            
           
        }

        public void OrderSort()
        {
            OrderList.Sort();
            foreach (Order o in OrderList)
            {
                Console.WriteLine(o.ToString());
            }
        }

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
        public void Export(String ExportPath)
        {

            using (FileStream fs = new FileStream(ExportPath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, OrderList);
            }
            Console.WriteLine("\nSerialized as XML:");
            Console.WriteLine(File.ReadAllText(ExportPath));


        }
        public void Import(String ImportPath)
        {
            using (FileStream fs = new FileStream(ImportPath, FileMode.Open))
            {
                List<Order> OrderList2 = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from s.xml");

                foreach (Order order in OrderList2)
                {
                    if (!(OrderList.Contains(order))){
                        OrderList.Add(order);
                    }
                    else
                    {
                        Console.WriteLine("Order exists!");
                    }
                    
                }

            }
        }

    }
}
