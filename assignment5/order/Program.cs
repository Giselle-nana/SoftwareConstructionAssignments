using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goods> goods1 = new List<Goods>(2)
            {
                new Goods("fruits", 10, 1),
                new Goods("vegetables", 2, 3)
            };
            List<Goods> goods2 = new List<Goods>(2)
            {
                new Goods("planets", 100, 50),
                new Goods("flowers", 20, 30)
            };
            List<Goods> goods3 = new List<Goods>(3)
            {
                new Goods("fruits",20,2),
                new Goods("planets",20,60),
                new Goods("juice",100,3)
            };

           OrderService orderService = new OrderService();
           Order order1 = new Order(1, goods1, new Clients("张三"), 100);
           Order order2 = new Order(2, goods2, new Clients("李四"), 500);
           Order order3 = new Order(3, goods3, new Clients("王五"), 100);
            orderService.AddOrder(order2);
            orderService.AddOrder(order1);
            orderService.AddOrder(order3);
            for(int i=0;i<orderService.Orders.Count;i++)
            {
                System.Console.WriteLine(orderService.Orders[i].OrderNum);
            }
            //使用Lambda表达式进行自定义排序
            orderService.Orders.Sort((o1, o2) => (int)o1.Details.Amount - (int)o2.Details.Amount);

            for (int i = 0; i < orderService.Orders.Count; i++)
            {
                System.Console.WriteLine(orderService.Orders[i].OrderNum);
            }

        }
    }
}
