using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSerialize
{
    public partial class Form1 : Form
    {
        public string KeyWord { get; set; }
        public OrderService os = new OrderService();
        public Form1()
        {
            InitializeComponent();
            OrderItem apple = new OrderItem(1,"apple",10.0, 80);
            OrderItem egg = new OrderItem(2, "eggs", 1.2, 200);
            OrderItem milk = new OrderItem(3, "milk", 50, 10);

            Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
            Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });


            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            OrderBindingSource.DataSource = os.orders;
            //绑定查询条件
            CheckBox.DataBindings.Add("Text", this, "KeyWord");
           


        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxCheckBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrderIDQuery_Click(object sender, EventArgs e)
        {

            if (KeyWord == null || KeyWord == "")
            {
                OrderBindingSource.DataSource = os.orders;
            }
            else
            {
                OrderBindingSource.DataSource = os.orders
                    .Where(s => s.OrderId.ToString() == KeyWord);
            }
            OrderBindingSource.ResetBindings(true);
        }

        private void btnCustomerQuery_Click(object sender, EventArgs e)
        {
            if (KeyWord == null || KeyWord == "")
            {
                OrderBindingSource.DataSource = os.orders;
            }
            else
            {
                OrderBindingSource.DataSource = os.orders
                    .Where(s => s.Customer == KeyWord);
            }
            OrderBindingSource.ResetBindings(true);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {


            Form2 form2 = new Form2(new Order());
            if (form2.ShowDialog() == DialogResult.OK)
            {
                os.AddOrder(form2.currentOrder);
                OrderBindingSource.DataSource = os.orders;
                OrderBindingSource.ResetBindings(false);
            }





        }

        private void btnMedifyOrder_Click(object sender, EventArgs e)
        {
            Order currentOrder = OrderBindingSource.Current as Order;
            if (currentOrder == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            Form2 form2 = new Form2();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    os.UpdateOrder(currentOrder,form2.currentOrder );
                    OrderBindingSource.DataSource = os.orders;
                    OrderBindingSource.ResetBindings(false);
                }
           
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

            Order currentOrder = OrderBindingSource.Current as Order;
            if (currentOrder == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            os.RemoveOrder(currentOrder.OrderId);
            OrderBindingSource.DataSource = os.orders;
            OrderBindingSource.ResetBindings(false);



        }


        private void OrderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void ItemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        

        private void ItemGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void OrderGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
