using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("BrandId=3");
            Console.WriteLine();
            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine();
            Console.WriteLine("ColorId=2");
            Console.WriteLine();
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine();
            Console.WriteLine("DailyPrice=0");
            Console.WriteLine();
            carManager.Add(new Car { BrandId = 3, ColorId = 3, DailyPrice = 0, ModelYear = 2016, Description = "Nissan Juke Skypack" });
            
            Console.WriteLine();
            Console.WriteLine("BrandName>=2");
            Console.WriteLine();
            brandManager.Add(new Brand { BrandName = "A" });
        }
    }
}
