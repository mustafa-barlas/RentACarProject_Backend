using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, Context>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            //using (var context = new Context())
            //{
            //    var result = from x in context.cars
            //                 join y in context.rentals
            //                 on x.CarId equals y.CarId
            //                 from r in context.rentals
            //                 join c in context.customers
            //                 on r.CustomerId equals c.CustomerId
            //                 select new RentalDetailDto
            //                 { RentalId = y.RentalId, CarId = x.CarId, RentalName = y.RentalName, CustomerId = c.CustomerId, CustomerName = c.CustomerName,  CarName = x.CarName ,Price = y.DailyPrice };
            //    return result.ToList();
            //}
            throw new NotImplementedException();
        }
    }
}
