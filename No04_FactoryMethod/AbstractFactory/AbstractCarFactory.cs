using System;
using System.Collections.Generic;
using System.Text;

namespace No04_FactoryMethod.AbstractFactory
{
    //public class CarFactory
    //{
    //    public AbstractCar CreateCar()
    //    {
    //        return new HongQiCar();
    //    }
    //}

    public abstract class AbstractCarFactory
    {
        public abstract AbstractCar CreateCar();
    }
}
