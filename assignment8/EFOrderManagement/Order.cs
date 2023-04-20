using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFOrderManagement
{

  /**
   **/
  public class Order{

    private List<OrderDetail> details=new List<OrderDetail>();
    [Key]
    public int OrderId { get; set; }
    
    
    public Customer ICustomer { set; get; }

    [Required]
    public string CustomerName { get; set; }
    [Required]
    public int CustomerId { get; set; }
    [Required]
    public DateTime CreateTime { get; set; }

        // public List<OrderDetail> details = new List<OrderDetail>();
    [Required]
    public double TotalPrice
    {
        get => details.Sum(item => item.Price);
    }

        public Order() {details = new List<OrderDetail>(); CreateTime = DateTime.Now; }

    public Order(int orderId,Customer customer ,List<OrderDetail> items) {
      this.OrderId = orderId;
      this.ICustomer = customer;
      this.CustomerId = customer.CustomerId;
      this.CustomerName = customer.CompanyName;
      this.details = items;
      this.CreateTime = DateTime.Now;
      
    }

    public Order(int orderId, Customer customer)
    {
        this.OrderId = orderId;
        this.ICustomer = customer;
        this.CustomerId = customer.CustomerId;
            this.CustomerName = customer.CompanyName;
        this.CreateTime = DateTime.Now;

    }

        public List<OrderDetail> Details {
      get { return details; }
    }

    /*public double TotalPrice {
      get => details.Sum(item => item.TotalPrice);
    }*/

    public void AddItem(OrderDetail orderItem) {
      if(details.Contains(orderItem))
        throw new ApplicationException($"添加错误：订单项{orderItem.GoodName} 已经存在!");
      details.Add(orderItem);
    }

        /* public void RemoveDetail(OrderDetail orderItem) {
           Details.Remove(orderItem);
         }*/


    public override string ToString()
    {
        StringBuilder strBuilder = new StringBuilder();
        strBuilder.Append($"Id:{OrderId}, customer:{CustomerName},orderTime:{CreateTime}");
        details.ForEach(od => strBuilder.Append("\n\t" + od));
        return strBuilder.ToString();
    }

        /* public override bool Equals(object obj) {
           var order = obj as Order;
           return order != null &&
                  OrderId == order.OrderId;
         }

         public override int GetHashCode() {
           var hashCode = -531220479;
           hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
           hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);
           hashCode = hashCode * -1521134295 + CreateTime.GetHashCode();
           return hashCode;
         }

         public int CompareTo(Order other) {
           if (other == null) return 1;
           return this.OrderId.CompareTo(other.OrderId);
         }*/
    }
}
