using No02_AbstractFactory.AbstractFactoyGame;
using No02_AbstractFactory.NoChangePart;
using static No02_AbstractFactory.ModernStyleGame.ModernObjects;

namespace No02_AbstractFactory
{
    public class GameApp
    {
        public static void Main()
        {
            //GameManager gameManager0 = new GameManager(new FacilitiesFactory());  //抽象的方法是不可以调用的，可以改用接口的方式
            GameManager gameManager = new GameManager(new ModernFacilitiesFactory());

            gameManager.BuildGameFacilities();
            gameManager.Run();
        }
    }
}
