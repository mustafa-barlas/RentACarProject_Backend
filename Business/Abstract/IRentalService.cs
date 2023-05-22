using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        List<Rental> GetAll();

        List<Rental> GetByCarId(int id);

        List<Rental> GetByUnitPrice(decimal min, decimal max);

        List<RentalDetailDto> GetRentalDetails();
    }
}
