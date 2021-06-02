using Business.Concrete;
using System;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { CarName = "izks",BrandId = 8, ColorId = 2, DailyPrice = 1000, Description = "deneme", ModelYear = 2012});

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }

            
        }
    }
}
