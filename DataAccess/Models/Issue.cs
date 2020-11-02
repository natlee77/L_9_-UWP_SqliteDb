using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Issue
    {
        public Issue()
        {

        }

        public Issue(long id, long customerId, string title, string description, string status, DateTime created)
        {
            Id = id;
            CustomerId = customerId;
            Title = title;
            Description = description;
            Status = status;
            Created = created;
        }

        public long Id { get; set; }
        public long CustomerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
