using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;


namespace EFOrderManagement
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext:DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());//当实体类结构改变时，重新生成数据库
        }

        public DbSet<Order> Orders { set; get; }

        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Good> Goods { set; get; }
        public DbSet<Customer> Customers { set; get; }
    }
}
