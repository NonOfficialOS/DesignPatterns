using No04_FactoryMethod.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace No04_FactoryMethod.Instances.HongQi
{
    public class HongQiCarFactory : AbstractCarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new HongQiCar();
        }
    }
}
