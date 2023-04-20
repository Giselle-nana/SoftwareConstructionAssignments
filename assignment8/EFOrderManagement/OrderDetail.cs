using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFOrderManagement
{

    /**
     **/
    public class OrderDetail {

        [Key, Column(Order = 0)]
        //public int OrderId { get=>IOrder.OrderId; }//订单号
        public int OrderId { get; set; }
        public Order IOrder { set; get; }
      //  public Order IOrder { set; get; }
        [Key, Column(Order = 1)]
        public int GoodId { get; set; }//货物号
        [Required]
        public string  GoodName { get; set; }
        
        public Good Igood { set; get; }
       // public Good MGood { set; get; }
        [Required]
        public double Price {  get => Igood == null ? 0.0 : Igood.UnitPrice * Quantity*Discount; }//总价
        [Required]
        public int Quantity { get ; set; }
        [Required]
        public double Discount { set; get; }
    public OrderDetail() { }

    public OrderDetail(int orderId,Good good, int quantity)
    {
            //this.OrderId = orderId;
            //this.GoodId = goodId;
        //this.IOrder = order;
        this.Igood = good;
        this.OrderId = orderId;
        this.GoodId = good.GoodId;
        this.GoodName = good.GoodName;
        this.Quantity = quantity;
        this.Discount =1;
        
    }
        public OrderDetail(int orderId, Good good, int quantity,double discount) {
            //this.IOrder = order;
            this.OrderId = orderId;
            this.Igood = good;
            this.GoodId = good.GoodId;
            this.GoodName = good.GoodName;
            this.Quantity = quantity;
            this.Discount = discount;
            //this.Price = Quantity * Igood.UnitPrice * Discount;
        }

        public override string ToString()
        {
            return $"goods:{GoodName},quantity:{Quantity},totalPrice:{Price},Discount:{Discount}";
        }
    }
}
