using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderWinForm
{
    public partial class Form1 : Form
    {
        public List<Order> orders = new List<Order>();
        OrderService orderService = new OrderService();
        public string Type { get; set; }//查询数据类型
        public string KeyWord { get; set; }//查询数据内容
        public Form1()
        {
            InitializeComponent();
            Order order1 = new Order(1, new Customer(1, "customer1"), new DateTime(2023, 3, 28));
            order1.AddDetails(new OrderDetail(new Goods(1, "good1", 10), 20));
            order1.AddDetails(new OrderDetail(new Goods(2, "good2", 5), 30));
            orders.Add(order1);
            Order order2 = new Order(2, new Customer(2, "customer2"), new DateTime(2023, 3, 28));
            order2.AddDetails(new OrderDetail(new Goods(3, "good3", 7), 20));
            orders.Add(order2);
            Order order3 = new Order(3, new Customer(3, "customer3"), new DateTime(2023, 3, 29));
            order3.AddDetails(new OrderDetail(new Goods(4, "good4", 70), 3));
            orders.Add(order3);
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderBindingSource.DataSource = orders;
            this.comboBox1.SelectedIndex = 0;//默认值
            comboBox1.DataBindings.Add("SelectedItem", this, "Type");
            textBox1.DataBindings.Add("Text", this, "KeyWord");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "增加订单";
            form2.ShowDialog();
            if(form2.DialogResult==DialogResult.OK)
            {
                bool flag = true;
                for(int i=0;i<orders.Count;i++)
                {
                    if(form2.Norder.Id==orders[i].Id)
                    {
                        MessageBox.Show("创建订单号已存在！");
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    orderBindingSource.Add(form2.Norder);
                }
               
            }
        }

        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            /*comboBox1.DataBindings.Add("SelectedItem", this, "Type");
            textBox1.DataBindings.Add("Text", this, "KeyWord");*/
            if (KeyWord==null||KeyWord=="")
             {
                 orderBindingSource.DataSource = orders;
             }
             else
             {
                 switch(Type)
                 {
                     case "ID":
                         orderBindingSource.DataSource = orderService.GetById(Convert.ToInt32(KeyWord));
                         break;
                     case "客户名":
                         orderBindingSource.DataSource = orderService.QueryByCustomerName(KeyWord);
                         break;
                     case"货物名":
                         orderBindingSource.DataSource = orderService.QueryByGoodsName(KeyWord);
                         break;
                     case "总价":
                         orderBindingSource.DataSource = orderService.QueryByTotalPrice(Convert.ToInt32(Type));
                         break;
                     default:
                         orderBindingSource.DataSource = orders;
                         break;
                 }    

             }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int i = gvOrder.CurrentRow.Index;
            List<OrderDetail> details = new List<OrderDetail>();
            Order selectedOrder = orders[i];
            for(int j=0;j<orders[i].Details.Count;j++)
            {
                details.Add(orders[i].Details[j]);
            }
              
            Form2 form2 = new Form2(details,selectedOrder.Id,selectedOrder.Customer.Id,selectedOrder.Customer.Name);
            form2.Text = "修改订单";
            form2.ShowDialog();
            if (form2.DialogResult==DialogResult.OK)
            {
                //删除已有订单 添加新订单
                orders.RemoveAt(i);
                orders.Add(form2.Norder);
                orderBindingSource.ResetBindings(true);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = gvOrder.CurrentRow.Index;
            DialogResult dr = MessageBox.Show("您确定删除此订单吗？", "删除订单", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
               orders.RemoveAt(i);
               orderBindingSource.ResetBindings(true);
            }
        }
    }
}
