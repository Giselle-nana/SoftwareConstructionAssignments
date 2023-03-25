using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order
{
    public class Goods
    {
        public string Name { get; }//货物名称
        public double Price { get; }//货物单价
        public int Num { get; }//货物数量
        public Goods(string Name,double price,int num)
        {
            this.Name = Name;
            this.Price = price;
            this.Num = num;
        }

        public override bool Equals(object obj)
        {
            Goods g = obj as Goods;
            return g != null &&
                g.Name == this.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        public override string ToString()
        {
            return "货物名称：" + Name+" "+"货物单价："+Price+" "+"货物数量："+Num;
        }
    }
}
