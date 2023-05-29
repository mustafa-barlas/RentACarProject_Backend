using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService 
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int id);

        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<Car>> GetCarsByColorId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<Car> GetById(int id);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

    }
}
