using No04_FactoryMethod.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace No04_FactoryMethod.Instances.DongFeng
{
    public class DongFengCarFactory : AbstractCarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new DongFengCar();
        }
    }
}
