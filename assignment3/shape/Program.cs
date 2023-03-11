using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    interface IShape
    {
        void Illegal();
        double GetArea();
    }
     class Rectangle:IShape
    {
        public double Len { set; get; }
        public double Width { set; get; }
       public Rectangle(double len,double width)
        {
            this.Len = len;
            this.Width = width;
        }
        public double GetArea()
        {
            return Len * Width;
        }
        public void Illegal()
        {
            if(Len<=0||Width<=0)
            {
                throw new ArgumentException("长方形的边长必须为正数");
            }
        }

    }
    class Square: IShape
    {

        public double Side { get; set; }

        public Square(double Side)
        {
            this.Side = Side;
        }
        public double GetArea()
        {
            return Side * Side;
        }
        public void Illegal()
        {
            if(Side<=0)
            {
                throw new ArgumentException("正方形的变成必须为正数");
            }
        }
    }
    class Triangle: IShape
    {
       public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(int a,int b,int c)
        {
            this.A = a;this.B = b;this.C = c;
        }
        public double GetArea()
        {
            //半周长
            double p = (A + B + C) / 2;
            return Math.Sqrt((p*(p-A)*(p-B)*(p-C)));
        }
        public void Illegal()
        {
            if (A <= 0 || B <= 0||C<=0)
            {
                throw new ArgumentException("三角形的边长必须为正数");
            }
            if(A+B<=C||A+C<=B||B+C<=A)
            {
                throw new ArgumentException("三角形的第三边必须大于其余两边之和");
            }
                
        }
    }
    class IShapeFactory
    {
        public IShape CreateShape(int type)
        {
            Random random = new Random();
            switch (type)
            {
                case 1:
                    return new Rectangle(random.Next(1,5), random.Next(1,5));
                case 2:
                    return new Square(random.Next(1,5));
                case 3:
                    return new Triangle(random.Next(1,5), random.Next(1,5), random.Next(1,5));
                default:
                    throw new ArgumentException("不存在此类型的形状");
                    

                   
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //随机生成十个对象
                int num = 10;
                double total = 0;
                Random random = new Random();
                IShape shape;
                IShapeFactory factory = new IShapeFactory();
                for(int i=0;i<num;i++)
                {
                   int figure = random.Next(1, 4);
                    shape = factory.CreateShape(figure);
                    total += shape.GetArea();
                }
                System.Console.WriteLine("生成的是个图形的面积之和为："+total);
                


            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
           

        }
    }
}
