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
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //brandManager.Add(new Brand { BrandName="Fiat"});
            //colorManager.Add(new Color { ColorName="Beyaz"});
            //carManager.Add(new Car { BrandId = 2002, ColorId = 1002, DailyPrice = 300, ModelYear = 2016, Description = "Fiat 500 Star" });

            //brandManager.Update(new Brand {BrandId=2002,BrandName="FIAT"});
            //colorManager.Update(new Color {ColorId=1002,ColorName="BEYAZ"});
            //carManager.Update(new Car { Id=2004,BrandId = 2002, ColorId = 1002, DailyPrice = 200, ModelYear = 2012, Description = "Fiat 500 Star" });

            //carManager.Delete(new Car { Id = 2004, BrandId = 2002, ColorId = 1002, DailyPrice = 200, ModelYear = 2012, Description = "Fiat 500 Star" });
            //brandManager.Delete(new Brand { BrandId=2002,BrandName="FIAT"});
            //colorManager.Delete(new Color { ColorId=1002,ColorName="BEYAZ"});

            Console.WriteLine();
            Console.WriteLine("Car Detail");
            Console.WriteLine();
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3}", car.Description, car.BrandName, car.ColorName, car.DailyPrice);
            }

            Console.WriteLine();
            Console.WriteLine("Car List");
            Console.WriteLine();
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine();
            Console.WriteLine("Color List");
            Console.WriteLine();
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("{0} -- {1}", color.ColorId, color.ColorName);
            }

            Console.WriteLine();
            Console.WriteLine("Brand List");
            Console.WriteLine();
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} -- {1}", brand.BrandId, brand.BrandName);
            }

            Console.WriteLine();
            Console.WriteLine("carManager.GetById(3)");
            Console.WriteLine();
            Car carTemp = carManager.GetById(3);
            Console.WriteLine(carTemp.Id + " " + carTemp.BrandId + " " +
                carTemp.ColorId + " " + carTemp.ModelYear + " " +
                carTemp.DailyPrice + " " + carTemp.Description);

            Console.WriteLine();
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
