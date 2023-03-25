using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order
{
    public class OrderDetails
    {

        public List<Goods> goods;
       
        public double Amount { get; set; }//订单金额
        public OrderDetails(List<Goods> goods,double amount)
        {
            this.goods = goods;
            this.Amount = amount;
        }

        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return od != null &&
                od.goods.Equals(this.goods) &&
                od.Amount == this.Amount;
        }

        public override int GetHashCode()
        {
            int hashCode = -310833396;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Goods>>.Default.GetHashCode(goods);
            hashCode = hashCode * -1521134295 + Amount.GetHashCode();
            return hashCode;
        }

       public override string ToString()
        {

            string result = "商品信息为：";
            foreach(Goods g in goods)
            {
                result += g.ToString();
            }
            return result;
        }

    }
}
