using Entities.Concrete;
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

        Customer GetById(int id);

        void Update(Customer customer);

        void Delete(Customer customer);

        void Add(Customer customer);
    }
}
