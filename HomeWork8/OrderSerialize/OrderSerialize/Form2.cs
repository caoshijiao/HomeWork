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
    public partial class Form2 : Form
    {
        public Order currentOrder { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Order currentOrder)
        {
            InitializeComponent();
            this.currentOrder = currentOrder;
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(new OrderItem());
            try
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    uint index = 0;
                    if (currentOrder.Items.Count != 0)
                    {
                        index = currentOrder.Items.Max(i => i.Index) + 1;
                    }
                    form3.OrderItem.Index = index;
                    currentOrder.AddItem(form3.OrderItem);
                    ItemCreateBindingSource.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = ItemCreateBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            Form3 form3 = new Form3(orderItem);
            if (form3.ShowDialog() == DialogResult.OK)
            {
                ItemCreateBindingSource.ResetBindings(false);
            }

        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = ItemCreateBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            currentOrder.RemoveItem(orderItem);
            ItemCreateBindingSource.ResetBindings(false);
        }
    
    }
}
