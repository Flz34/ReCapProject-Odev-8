using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2012, DailyPrice = 15000, Description = "standart model"},
                new Car{Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2013, DailyPrice = 60000, Description = "İkinci Açıklama"},
                new Car{Id = 3, BrandId = 2, ColorId = 2, ModelYear = 2010, DailyPrice = 100000, Description = "front-wheel"},
                new Car{Id = 4, BrandId = 2, ColorId = 1, ModelYear = 2013, DailyPrice = 200000, Description = "8 bass speakers"},
                new Car{Id = 5, BrandId = 3, ColorId = 3, ModelYear = 2015, DailyPrice = 750000, Description = "front-wheel"},
                new Car{Id = 6, BrandId = 3, ColorId = 3, ModelYear = 2014, DailyPrice = 980000, Description = "front-wheel"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //referansa ihtiyacım var
            Car CarToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            //arabaları listeleyeceğiz
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=> c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c=> c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}
