using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int RentalId { get; set; }

        public int CarId { get; set; }

        public int  CustomerId { get; set; }

        public string RentalName { get; set; }
        
        public DateTime RenDate { get; set; }

        public DateTime DeadlineTime { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

    }
}
