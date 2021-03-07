using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace No03_Builder
{
    public class Client
    {
        public void Main()
        {

            //假如现在要创建更多种类的房子，比如ClassicHouse,ModerHouse等，如何实现动态创建House呢？
            //配置文件，实现动态创建House

            //获取程序集
            string assemblyName = Configuration.a[""];

            //固定某一种房子的创建
            House house = GameManager.CreateHouse(new RomanHouseBuilder());

        }
    }
}
