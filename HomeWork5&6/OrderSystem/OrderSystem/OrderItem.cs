using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderItem
    {
        public String Name { get; set; }
        public int Num { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get { return Num * Price; } }


        public OrderItem()
        {

        }
        public OrderItem(String Name, int Num, double Price)
        {
            this.Name = Name;
            this.Num = Num;
            this.Price = Price;
        }
        public override string ToString()
        {
            return "商品名：" + Name + "  数量：" + Num + "  单价：" + Price + "  总价：" + TotalPrice;
        }

    }
}
