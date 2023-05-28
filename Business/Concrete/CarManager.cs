using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
       private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal=carDal;
        }

        public IResult Add(Car car)
        {
             _carDal.Add(car);
            return new Result(true,"başarılı");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, "başarılı");
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, "başarılı");
        }

        public List<Car> GetAll()
        {
            return  _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(x => x.BrandId == id);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(x => x.CarId == id);
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(x => x.DailyPrice >= min && x.DailyPrice <= max);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(x => x.ColorId == id);
        }


        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}


