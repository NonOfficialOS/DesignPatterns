using No02_AbstractFactory.AbstractFactoyGame;

namespace No02_AbstractFactory.ModernStyleGame
{
    class ModernObjects
    {
        /// <summary>
        /// 道路
        /// </summary>
        public class ModernRoad : Road
        {
        }

        /// <summary>
        /// 建筑屋
        /// </summary>
        public class ModernBuilding : Building
        {
        }

        /// <summary>
        /// 隧道
        /// </summary>
        public class ModernTunnel : Tunnel
        {
        }

        /// <summary>
        /// 丛林
        /// </summary>
        public class ModernJungle : Jungle
        {

        }

        /// <summary>
        /// 设施
        /// </summary>
        public class ModernFacilitiesFactory : FacilitiesFactory
        {
            public override Road CreateRoad()
            {
                return new ModernRoad();
            }

            public override Building CreateBuilding()
            {
                return new ModernBuilding();
            }

            public override Tunnel CreateTunnel()
            {
                return new ModernTunnel();
            }

            public override Jungle CreateJungle()
            {
                return new ModernJungle();
            }
        }
    }
}
