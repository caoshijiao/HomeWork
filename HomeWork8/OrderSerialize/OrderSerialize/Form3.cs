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
    public partial class Form3 : Form
    {
        public OrderItem OrderItem { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(OrderItem orderItem)
        {
            this.OrderItem = orderItem;
            this.ItemBindingSource.DataSource = orderItem;
            Double.TryParse(textBox3.Text, out orderItem.Price);
            Int32.TryParse(textBox2.Text, out orderItem.Quantity);
            orderItem.GoodsName = textBox1.Text;

            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
