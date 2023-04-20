using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            //添加订单
            Good good1 = new Good(1, "g1", 3);
            Good good2 = new Good(2, "g2", 4);
            Good good3 = new Good(3, "g3", 5);
            Customer cus1 = new Customer(1, "c1", "road1");
            Customer cus2 = new Customer(2, "c2", "road2");
            Customer cus3 = new Customer(3, "c3", "road3");
            OrderDetail detail1 = new OrderDetail(1, good1, 10, 0.7);
            OrderDetail detail2 = new OrderDetail(1, good2, 20, 0.8);
            OrderDetail detail3 = new OrderDetail(2, good3, 15);
            OrderDetail detail4 = new OrderDetail(3, good1, 20, 0.8);
            OrderDetail detail5 = new OrderDetail(3, good3, 20, 0.8);
            Order order1 = new Order(1, cus1);
            Order order2 = new Order(2, cus2);
            Order order3 = new Order(3, cus3);
            order1.AddItem(detail1);order1.AddItem(detail2);
            order2.AddItem(detail3);
            order3.AddItem(detail4);order3.AddItem(detail5);
            OrderService service = new OrderService();
            try
            {

                //增加订单
                System.Console.WriteLine("增加订单：");
                service.Add(order1);
                service.Add(order2);
                service.Add(order3);
                List<Order> orders = service.QueryAll();
                foreach (Order o in orders)
                {
                  System.Console.WriteLine(o);
                }

                //删除订单
                System.Console.WriteLine("删除订单：");
                service.Delete(order1.OrderId);
                orders = service.QueryAll();
                foreach (Order o in orders)
                {
                    System.Console.WriteLine(o);
                }

                //修改订单
                System.Console.WriteLine("修改订单：");
                Order morder = new Order(2, cus3);
                Good mgood = new Good(3, "g3", 5);
                OrderDetail detail = new OrderDetail(2, mgood, 15);
                morder.AddItem(detail);
                service.Modify(morder);
                orders = service.QueryAll();
                foreach (Order o in orders)
                {
                    System.Console.WriteLine(o);
                }
               // List<Order> orders = new List<Order>();
                //查询订单
                System.Console.WriteLine("查询三号订单：");
                Order order=service.QueryOrdersByOrderId(3);
                System.Console.WriteLine(order);
                System.Console.WriteLine("客户名c3：");
                orders=service.QueryOrdersByCustomerName("c3");
                foreach (Order o in orders)
                {
                    System.Console.WriteLine(o);
                }
                System.Console.WriteLine("货物名g3：");
               List<OrderDetail>details= service.QueryOrdersByGoodsName("g3");
                foreach (OrderDetail od in details)
                {
                    System.Console.WriteLine(od);
                }

            }
            catch(ArgumentException e)
            {
                System.Console.WriteLine(e.Message);
            }
            








            



        }
    }
}
