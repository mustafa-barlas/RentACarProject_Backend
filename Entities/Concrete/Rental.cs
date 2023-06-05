using Core.Entities;
using Entities.Concrete;
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

        public DateTime ReturnDate { get; set; }

        public string Description { get; set; }

        public decimal DailyPrice { get; set; }

        public bool IsAvilable { get; set; }

    }
}