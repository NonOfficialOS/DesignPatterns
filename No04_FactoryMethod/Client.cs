using No04_FactoryMethod.Instances.DongFeng;
using No04_FactoryMethod.Instances.HongQi;
using System;
using System.Collections.Generic;
using System.Text;

namespace No04_FactoryMethod
{
    public class Client
    {
        public static void Main()
        {
            CarTestFramework carTestFramework = new CarTestFramework();

            //carTestFramework.BuildTestContext(new CarFactory());
            carTestFramework.BuildTestContext(new HongQiCarFactory());
            carTestFramework.BuildTestContext(new DongFengCarFactory());

            //Activator.CreateInstance(string "TypeName");
        }
    }
}
