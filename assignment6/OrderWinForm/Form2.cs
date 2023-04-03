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
    public partial class Form2 : Form
    {
        public Order Norder = new Order();
        public string OrderID { get; set; }
        public string CusID { get; set; }
        public string CusName { get; set; }
        public DateTime time { get; set; }
        public List<OrderDetail> Details = new List<OrderDetail>();
       
        public Form2()
        {
            InitializeComponent();
            //订单创建时间
            DateTime current = DateTime.Now;
            time = new DateTime(current.Year, current.Month, current.Day);
            string s = current.Year.ToString() + "/" + current.Month.ToString() + "/" + current.Day.ToString();
            label7.Text = s;
            OrderID = "";
            CusID = "";
            CusName = "";
            tbOrderID.DataBindings.Add("Text", this, "OrderId");
            tbCusID.DataBindings.Add("Text", this, "CusId");
            tbCusName.DataBindings.Add("Text", this, "CusName");
            orderDetailsbindingSource1.DataSource = Details;



        }
        public Form2(List<OrderDetail>details,int orderID,int cusID,string cusName)
        {
            this.Details = details;
            InitializeComponent();
            //订单创建时间
            DateTime current = DateTime.Now;
            time = new DateTime(current.Year, current.Month, current.Day);
            string s = current.Year.ToString() + "/" + current.Month.ToString() + "/" + current.Day.ToString();
            label7.Text = s;
            this.OrderID =orderID.ToString();
            this.CusID =cusID.ToString();
            this.CusName = cusName;
            tbOrderID.DataBindings.Add("Text", this, "OrderId");
            tbCusID.DataBindings.Add("Text", this, "CusId");
            tbCusName.DataBindings.Add("Text", this, "CusName");
            orderDetailsbindingSource1.DataSource = Details;


        }
        private void tbOrderID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCusID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCusName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Text = "添加明细";
            form3.ShowDialog();
            for (int j = 0; j < dgvDetails.Rows.Count; j++)
            {
                Norder.AddDetails(Details[j]);
            }
            if (form3.DialogResult==DialogResult.OK)
            {
                Norder.AddDetails(form3.orderDetail);
                Details.Add(form3.orderDetail);
                //orderDetailsbindingSource1.Add(form3.orderDetail);
                orderDetailsbindingSource1.ResetBindings(true);
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if (OrderID==""||CusID==""||CusName=="")
            {
                MessageBox.Show("创建订单内容不能为空！");
               
            }
            else
            {
                Norder.Id = Convert.ToInt32(OrderID);
                Norder.Customer = new Customer(Convert.ToInt32(CusID), CusName);
                Norder.CreateTime = time;
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Text = "修改明细";
            form3.ShowDialog();
            if(form3.DialogResult==DialogResult.OK)
            {
                int i = dgvDetails.CurrentRow.Index;//选中明细行的索引
                Details[i] = form3.orderDetail;
                orderDetailsbindingSource1.ResetBindings(true);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = dgvDetails.CurrentRow.Index;
            
            DialogResult dr = MessageBox.Show("您确定删除此明细吗？", "删除明细", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Details.RemoveAt(i);
                orderDetailsbindingSource1.ResetBindings(true);
                Norder.Details.Clear();
                //再添加修改后明细
                for(int j=0;j<dgvDetails.Rows.Count;j++)
                {
                    Norder.AddDetails(Details[j]);
                }
                
            }
           
               
        }
    }
}
