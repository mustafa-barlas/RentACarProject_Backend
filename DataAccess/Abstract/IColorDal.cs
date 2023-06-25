using Core.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color> 
    {
        List<ColorDetailDto> GetColorDetails();
    }
}
