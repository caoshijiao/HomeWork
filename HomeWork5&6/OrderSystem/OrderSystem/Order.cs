using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Order : IComparable
    {
        public String ID;//订单号
        public String CardID;//会员卡号
        public List<OrderItem> OrderItemList;//订单明细
        public double OrderPrice;//订单总金额

        public Order()
        {

        }
        public Order(String ID, String CardID)
        {
            this.ID = ID;
            this.CardID = CardID;
            OrderItemList = new List<OrderItem>();
            OrderPrice = 0;


        }
        public void AddOrderItem(OrderItem orderItem)
        {
            if (!(OrderItemList.Contains(orderItem)))
            {
                OrderItemList.Add(orderItem);
                OrderPrice += orderItem.TotalPrice;
            }
            else
            {
                return;
            }

        }
        public String OrderItemToString()
        {
            String OrderItemToString = null;
            foreach (OrderItem o in OrderItemList)
            {

                OrderItemToString = OrderItemToString + "\n" + o.ToString();
            }
            return OrderItemToString;
        }



        public override string ToString()
        {


            return "订单号：" + ID + "  会员卡号：" + CardID + "\n" + "订单明细：" + OrderItemToString() + "\n" + "订单总金额：" + OrderPrice;
        }

        public int CompareTo(object obj)
        {
            Order order = obj as Order;
            if (order == null)
                throw new System.ArgumentException();
            return this.ID.CompareTo(order.ID);
        }
    }
}
