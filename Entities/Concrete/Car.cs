using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }

        public string CarName { get; set; }

        public int BrandId { get; set; }

        public short UnitsİnStock { get; set; }

        public decimal UnitsİnPrice { get; set; }
    }
}
