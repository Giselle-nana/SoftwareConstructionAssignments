using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order
{
    public class Clients:IComparable
    {
        public string Name { get; }
        public Clients(string name)
        {
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            Clients c = obj as Clients;
            return c != null &&
                c.Name == this.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        public override string ToString()
        {
            return "用户姓名：" + Name;
        }
        public int CompareTo(Object obj)
        {
            Clients client = obj as Clients;
            if(client==null)
            {
                throw new ArgumentException();
            }
            return this.Name.CompareTo(client.Name);
        }
    }
}
