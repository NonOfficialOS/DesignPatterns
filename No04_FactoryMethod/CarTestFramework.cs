using No04_FactoryMethod.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace No04_FactoryMethod
{
    public class CarTestFramework
    {
        //public void BuildTestContext()
        //public void BuildTestContext(Car car)    //变化02
        //public void BuildTestContext(AbstractCar car)   //变化03
        public void BuildTestContext(AbstractCarFactory carFactory)   //变化03
        {
            //Car car = new Car(); //变化01
            //...
            //car.StartUp();

            //变化03
            //AbstractCar c1 = new AbstractCar();
            //AbstractCar c2 = new AbstractCar();
            //AbstractCar c3 = new AbstractCar();

            //变化04：使用工厂方法
            AbstractCar c1 = carFactory.CreateCar();
            AbstractCar c2 = carFactory.CreateCar();
            AbstractCar c3 = carFactory.CreateCar();
        }

        //public void DoTest()
        public void DoTest(AbstractCar car)
        {
            //Car car = new Car();
            //...
        }

        //public TestData GetTestData()
        public TestData GetTestData(AbstractCar car)
        {
            //Car car = new Car();
            //...
            return null;
        }
    }

    public class TestData
    {
    }
}
