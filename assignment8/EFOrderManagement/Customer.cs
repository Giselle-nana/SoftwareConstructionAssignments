using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFOrderManagement
{
  public class Customer {
    [Key]
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    [Required]
    public string Address { get; set; }

    public Customer() {
    }

    public Customer(int customerId,string companyName,string address) {
            this.CustomerId = customerId;
            this.CompanyName = companyName;
            this.Address = address;
    }

   
  }
}
