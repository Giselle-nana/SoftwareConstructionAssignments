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
    public partial class Form3 : Form
    {
        public string Id { set; get; }
        public string Gname { set; get; }
        public string Price { set; get; }
        public string Num{set;get;}
        public OrderDetail orderDetail = new OrderDetail();
        public Form3()
        {
            InitializeComponent();
            tbID.DataBindings.Add("Text", this, "Id");
            tbName.DataBindings.Add("Text", this, "Gname");
            tbPrice.DataBindings.Add("Text", this, "Price");
            tbNum.DataBindings.Add("Text", this, "Num");
            Id = "";Gname = "";Price = "";Num = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Id==""||Gname==""||Price==""||Num=="")
            {
                MessageBox.Show("创建订单明细内容不能为空！");
            }
            else
            {
                orderDetail.Goods = new Goods(Convert.ToInt32(Id), Gname, float.Parse(Price));
                orderDetail.Quantity = Convert.ToInt32(Num);
            }
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
