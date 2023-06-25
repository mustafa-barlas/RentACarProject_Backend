using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
           
            _rentalDal.Add(rental);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new  ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
           
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.ProductGetAll.ToString());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(x => x.Id == id),Messages.ProductGetAll);
        }

        public IDataResult<List<Rental>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(x => x.DailyPrice >= min && x.DailyPrice <= max),Messages.ProductGetAll);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
           return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(),Messages.ProductGetAll);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
