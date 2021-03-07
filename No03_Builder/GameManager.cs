using System;
using System.Collections.Generic;
using System.Text;

namespace No03_Builder
{
    public class GameManager
    {
        /// <summary>
        /// 创建一个完整的房子
        /// 这部分是稳定不变的
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static House CreateHouse(Builder builder)
        {
            //一扇门门
            builder.BuildDoor();

            //两扇窗
            builder.BuildWindows();
            builder.BuildWindows();

            //四面墙
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();

            //一个地板
            builder.BuildFloor();

            //一个天花板
            builder.BuildHouseCeiling();

            return builder.GetHouse();

        }
    }
}
