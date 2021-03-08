using System;
using System.Collections.Generic;
using System.Text;

namespace No04_FactoryMethod.AbstractFactory
{
    //public class Car  //变化01
    public abstract class AbstractCar   //变化02
    {
        //这里我们只关注车能做什么，至于是由什么组成，这里不关心
        //public void StartUp() { }
        //public void Run() { }
        //public void Turn(Direction direction) { }
        //public void Stop() { }

        public abstract void StartUp();
        public abstract void Run();
        public abstract void Turn(Direction direction);
        public abstract void Stop();
    }

    public class Direction
    {
    }
}
