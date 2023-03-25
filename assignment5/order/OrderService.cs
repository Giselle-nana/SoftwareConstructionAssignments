using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order
{
    public class OrderService
    {
        public List<Order> Orders { get; }
        public OrderService()
        {
            this.Orders = new List<Order> ();
        }
        //添加订单
        public void AddOrder(Order order)
        {
            if(IsExist(order))
            {
                throw new ArgumentException("此订单已存在！");
            }
            Orders.Add(order);
        }
        //删除订单
        public void DeleteOrder(Order order)
        {
            if(!IsExist(order))
            {
                throw new ArgumentException("此订单不存在！");
            }
            Orders.Remove(order);
        }
        //修改订单
        public void UpdateOrder(Order target,Order order)
        {
            if(IsExist(target))
            {
                int index = SearchIndex(target);
                Orders[index] = order;
            }
            else
            {
                throw new ArgumentException("不存在该订单！");
            }
        }
        //判断订单是否存在
        public bool IsExist(Order order)
        {
            int index = SearchIndex(order);
            if(index>-1&&index<Orders.Count)
            {
                return true;
            }
            return false;
        }
        //查询订单并返回索引
        public int SearchIndex(Order order)
        {
            for(int i=0;i<Orders.Count;i++)
            {
                if(Orders[i].Equals(order))
                {
                    return i;
                }
            }
            return -1;
        }
        //对订单号查询
        public List<Order> SearchNum(int num)
        {
            var query = from n in Orders
                         where n.OrderNum == num
                         orderby n.Details.Amount
                         select n;
            List<Order> target = query.ToList();
            return target;

        }
        //对货物信息查询
        public List<Order> SearchGoods(List<Goods>goods)
        {
            var query = from n in Orders
                        where n.Details.goods.Equals(goods)
                        orderby n.Details.Amount
                        select n;
            List<Order> target = query.ToList();
            return target;
        }
        //用户信息查询
        public List<Order> SearchClient(Clients client)
        {
            var query = from n in Orders
                        where n.Client.Equals(client)
                        orderby n.Details.Amount
                        select n;
            List<Order> target = query.ToList();
            return target;
        }
        //订单金额查询
        public List<Order> SearchAmount(double amount)
        {
            var query = from n in Orders
                        where n.Details.Amount == amount
                        orderby n.Details.Amount
                        select n;
            List<Order> target = query.ToList();
            return target;
        }

        public override bool Equals(object obj)
        {
            OrderService orderService = obj as OrderService;
            if(orderService==null)
            {
                return false;
            }
            if(this.Orders.Count!=orderService.Orders.Count)
            {
                return false;
            }
            for(int i=0;i<this.Orders.Count;i++)
            {
                if(this.Orders[i]!=orderService.Orders[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return -1897285908 + EqualityComparer<List<Order>>.Default.GetHashCode(Orders);
        }
        //排序
        public void Sort()
        {
            Orders.Sort();
        }
    }
}
