using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        List<CustomerDetailDto> GetCustomerDetails();

        Customer GetById(int id);

        void Update(Customer customer);

        void Delete(Customer customer);

        void Add(Customer customer);
    }
}
