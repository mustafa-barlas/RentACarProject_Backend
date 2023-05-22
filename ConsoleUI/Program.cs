

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            foreach (var item in rentalManager.GetRentalDetails())
            {
                Console.WriteLine(item.RentalName +" "+item.CarName);
            }
        }
    }
}