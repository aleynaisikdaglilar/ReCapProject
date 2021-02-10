using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.GetAll();

            Console.WriteLine("Listelendi");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine();

            Console.WriteLine("Araç eklendi");
            carManager.Add(new Car { Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 300, ModelYear = 2016, Description = "Nissan Juke Skypack" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine();

            Console.WriteLine("Aranan araç");
            Console.WriteLine(carManager.GetById(2).Description + " " + carManager.GetById(2).ModelYear);
            Console.WriteLine();

            Console.WriteLine("Son araç güncellendi");
            carManager.Update(new Car { Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 200, ModelYear = 2015, Description = "Nissan Juke Skypack" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine();

            Console.WriteLine("Son araç silindi");
            carManager.Delete(new Car { Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 200, ModelYear = 2015, Description = "Nissan Juke Skypack" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
        }
    }
}
