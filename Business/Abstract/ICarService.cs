using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService 
    {
        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int id);

        List<Car> GetByUnitPrice(decimal min, decimal max);

        List<Car> GetCarsByColorId(int id);

        List<CarDetailDto> GetCarDetails();

        Car GetById(int id);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

    }
}
