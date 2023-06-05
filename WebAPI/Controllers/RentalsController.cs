using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // ATRIBUTE : 

    //IOC   Inversion Of Control
    public class RentalsController : ControllerBase
    {
        private IRentalService _rentalService;


        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet]
        public List<Rental> GetAll()
        {
            
           
            var result = _rentalService.GetAll();
            return result.Data;
        }
    }
}
