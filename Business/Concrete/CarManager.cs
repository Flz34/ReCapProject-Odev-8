﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
             
        {
            if (car.CarName.Length>2 && car.DailyPrice>0)
            {
                Console.WriteLine("kaydedildi");
                _carDal.Add(car);
            }
            
            else
            {
                Console.WriteLine("Araba markası iki harften fazla olmalı ve günlük fiyatı sıfırdan büyük olmalı!!");
            }
            
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=> c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=> c.ColorId == id );
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
