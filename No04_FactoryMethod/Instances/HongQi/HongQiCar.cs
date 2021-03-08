using No04_FactoryMethod.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace No04_FactoryMethod.Instances.HongQi
{
    public class HongQiCar : AbstractCar
    {
        Enginee enginee1;
        Enginee enginee2;
        Enginee enginee3;
        Enginee enginee4;

        public override void Run() { }
        public override void StartUp() { }
        public override void Stop() { }
        public override void Turn(Direction direction) { }

        private class Enginee { }
    }
}
