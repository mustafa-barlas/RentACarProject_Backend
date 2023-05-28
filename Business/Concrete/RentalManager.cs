using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal=rentalDal;
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public Rental GetById(int id)
        {
            return _rentalDal.Get(x => x.RentalId == id);
        }

        public List<Rental> GetByUnitPrice(decimal min, decimal max)
        {
            return _rentalDal.GetAll(x => x.Price >= min && x.Price <= max);
        }

        public List<RentalDetailDto> GetRentalDetails()
        {
            return _rentalDal.GetRentalDetails();
        }
    }
}
