using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (var context = new Context())
            {
                var result =  from r in context.cars
                              join c in context.brands
                              on r.BrandId equals c.BrandId 
                              from a in context.cars
                              join s in context.colors
                              on a.CarId equals s.ColorId
                              select new CarDetailDto 
                              { BrandId = c.BrandId, CarId = r.CarId ,CarName = r.CarName , DailyPrice = r.DailyPrice ,ColorId = r.ColorId, BrandName = c.BrandName,ColorName =s.ColorName };

                return  result.ToList();
            }
        }
    }
}



