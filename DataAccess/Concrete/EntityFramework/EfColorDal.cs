using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, Context>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            throw new NotImplementedException();
        }
    }
}
