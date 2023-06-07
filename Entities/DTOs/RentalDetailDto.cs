using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }

        public int CarId { get; set; }

        public int CustomerId { get; set; }

        public string RentalName  { get; set; }

        public string CarName { get; set; }

        public string CustomerName { get; set; }

        public DateTime RenDate { get; set; }

        public DateTime DeadlineTime { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

    }
}
