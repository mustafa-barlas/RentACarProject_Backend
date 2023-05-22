using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, Context>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
           using (Context context = new Context())
            {
                var result = from r in context.rentals
                             join c in context.cars
                             on r.CarId equals c.CarId
                             select new RentalDetailDto { RentalId = r.RentalId ,RentalName = r.RentalName, CarName = c.CarName};

                return result.ToList();
            }
        }
    }
}
