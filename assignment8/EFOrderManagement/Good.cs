using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFOrderManagement
{
    public class Good
    {
        [Key]
        public int GoodId { set; get; }
        public string GoodName { get; set; }

        [Required]
        public double UnitPrice { get; set; }//单价

        public Good()
        {
        }

        public Good(int goodId, string goodName, double UnitPrice)
        {
            this.GoodId = goodId;
            this.GoodName = goodName;
            this.UnitPrice = UnitPrice;
        }

        


    }


}
