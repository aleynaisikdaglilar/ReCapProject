﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=800,ModelYear=2021,Description="Volkswagen Tiguan Elegance"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=700,ModelYear=2020,Description="Volkswagen Tiguan Life"},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=600,ModelYear=2019,Description="Audi A3 Sedan"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=500,ModelYear=2018,Description="Audi A3 Sportback"},
                new Car{Id=5,BrandId=3,ColorId=3,DailyPrice=400,ModelYear=2017,Description="Nissan Juke Tekna"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}