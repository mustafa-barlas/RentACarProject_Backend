

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental = new Rental();
            //rental.RentalId = 2;
            rental.RentalName = "parasors";
            rental.RenDate = DateTime.Now;
            rental.ReturnDate = DateTime.Parse("12.12.2023");
            rental.CarId = 2;
            rental.CustomerId = 2;
            rental.DailyPrice = 1560;
            rental.Description = "şık konforlu bi gelecek";
            rental.IsAvilable = true;


            if (rental.IsAvilable)
            {
                Console.WriteLine("ürün mevcut değil");
            }
            else
            {
                rentalManager.Add(rental);

            }
            


            //if (rental.IsAvilable = true)
            //{
            //    //rentalManager.Add(rental);
            //    Console.WriteLine(rental.RentalName);
            //    Console.WriteLine("ürün");
            //}
            
            //foreach (var item in rentalManager.GetAll().ToString())
            //{
            //    Console.WriteLine(item);
            //}



            //BrandManager brandManager = new BrandManager(new EfBrandDal());


            ////Console.WriteLine(brandManager.GetById(2).BrandName);

            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}

            //CarManager car = new CarManager(new EfCarDal());

            //Console.WriteLine();

            //foreach (var item in car.GetCarsByColorId(3))
            //{
            //    Console.WriteLine( item.CarName +"   "+ item.DailyPrice);
            //}

            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetails();

            //if (result.Success )
            //{
            //        foreach (var car in result.Data)
            //                    {
            //                        Console.WriteLine(car.CarName);
            //                    }

            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //var result = carManager.GetById(1);
            //Console.WriteLine(result.Data.CarName +"   "+ result.Data.ColorName);

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + " "+car.ColorName);
            //}



        }
    }
}