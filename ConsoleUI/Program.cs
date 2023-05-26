

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //foreach (var item in rentalManager.GetRentalDetails())
            //{
            //    Console.WriteLine(item.RentalName +" "+item.CarName);

            //}



            //BrandManager brandManager = new BrandManager(new EfBrandDal());


            ////Console.WriteLine(brandManager.GetById(2).BrandName);

            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}

            CarManager car = new CarManager(new EfCarDal());

            Console.WriteLine();

            foreach (var item in car.GetCarsByColorId(3))
            {
                Console.WriteLine( item.CarName +"   "+ item.DailyPrice);
            }
        }
    }
}