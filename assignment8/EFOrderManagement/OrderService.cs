using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOrderManagement
{
    class OrderService
    {
       // List<Order> orders = new List<Order>();

        //添加订单
        public void Add(Order order)
        {
            using 
            (var context = new OrderContext())
            {
                if(QueryOrdersByOrderId(order.OrderId)!=null)
                {
                    throw new ArgumentException("该订单已存在！");
                }
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        //删除订单
        public void Delete(int OrderId)
        {
            using(var context= new OrderContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.OrderId == OrderId);
                if(order!=null)
                {
                     context.Orders.Remove(order);
                     context.SaveChanges();
                 }
            }
        }

        //修改订单
       public void Modify(Order order)
        {
            using(var context= new OrderContext())
            {
                context.Entry(order).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //查询订单
        public List<Order> QueryAll()
        {
            using(var context= new OrderContext())
            {
                var order = context.Orders
                    .OrderBy(o => o.OrderId);
                return order.ToList();
            }
        }
        public Order QueryOrdersByOrderId(int orderId)
        {
            using(var context= new OrderContext())
            {
                var order = context.Orders.Include("Details")
                    .Where(o => o.OrderId == orderId);
                if(order==null)
                {
                    throw new ArgumentException("不存在该订单！");
                }
                return order.ToList().FirstOrDefault();
            }
        }

        public List<OrderDetail> QueryOrdersByGoodsName(string goodName)
        {
            using (var context = new OrderContext())
            {
                return context.OrderDetails
                     .Where(od => od.GoodName == goodName).ToList();
            }
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using(var context = new OrderContext())
            {
                var query = context.Orders.Include("Details")
                    .Where(o => o.CustomerName == customerName)
                    .OrderBy(o => o.OrderId);
                return query.ToList();
            }
        }

       
    }
}
