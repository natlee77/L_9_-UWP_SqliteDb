using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Customer
    {
        /* 
         Customer customer = new Customer();
         customer.Id = 1;
         customer.Name = "Hans";
         customer.Created = DateTime.Now;

         new Customer { Id = 1, Name = "Hans", Created = DateTime.Now }
        */
        public Customer()
        {

        }

        //Customer customer = new Customer(1, "Hans", DateTime.Now);
        public Customer(long id, string name, DateTime created)
        {
            Id = id;
            Name = name;
            Created = created;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
