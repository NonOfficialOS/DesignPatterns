using System;

namespace No01_Singleton
{
    /// <summary>
    /// sealed子类不能继承
    /// </summary>
    public sealed class Singleton
    {
        #region 单线程模式下可以奏效

        ////创建一个实例，后面不允许被修改
        //private static Singleton instance;

        ////既然实例不能修改，那么就不允许随便的创建实例，即构造函数不能是public(默认的构造函数是public的)
        //private Singleton() { }

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new Singleton();
        //        }
        //        return instance;
        //    }
        //}

        #endregion

        #region 多线程模式仍任可以奏效
        ////首先解释为何上例在多线程时不奏效。
        ////假如线程Thread1,Thread2同时运行到get下的if语句判断，那么此时的实例instance均为null，那么两条线程都会重新创建一个实例instance,故而违背了实例不变的初衷。
        //private static volatile Singleton instance = null;

        ////辅助工具
        //private static object lockHelper = new object();

        ////私有化构造函数
        //private Singleton() { }

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (lockHelper)
        //            {
        //                if (instance == null)
        //                {
        //                    instance = new Singleton();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}

        #endregion

        #region 使用readonly
        //内联初始化
        private static readonly Singleton Instance = new Singleton();

        static Singleton()
        {
            Instance = new Singleton();
        }

        private Singleton() { }
        #endregion
    }

    public class Test
    {
        public static void Main()
        {
            //由于构造函数是private,所以没有办法随便的创建一个新的实例
            //Singleton singleton=new Singleton();

            //验证创建的实例都是同一个对象
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            Console.WriteLine(Object.ReferenceEquals(singleton1, singleton2) == true);
        }
    }
}
