using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order
{
    public class Order:IComparable
    {
        public int OrderNum { get; set; }//订单号
        public Clients Client { get; set; }//用户信息
        public OrderDetails Details { get; set; }
        public Order(int ordernum,List<Goods> goods,Clients client,double amount)
        {
            this.OrderNum = ordernum;
            this.Client = client;
            this.Details=new OrderDetails(goods, amount);//创建订单明细
            //orderService.AddOrder(this);//将该订单加入订单服务中
        }

        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o != null &&
               this.OrderNum == o.OrderNum &&
               this.Client.Equals(o.Client);
        }

        public override int GetHashCode()
        {
            return 1460045325 + EqualityComparer<OrderDetails>.Default.GetHashCode(Details);
        }

        public override string ToString()
        {
            return Details.ToString();
        }

        public int CompareTo(Object obj)
        {
            Order order = obj as Order;
            if(order==null)
            {
                throw new ArgumentException();
            }
            return this.OrderNum.CompareTo(order.OrderNum);
        }
    }
}
