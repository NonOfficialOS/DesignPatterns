using No02_AbstractFactory.AbstractFactoyGame;

namespace No02_AbstractFactory.NoChangePart
{
    public class GameManager
    {
        private FacilitiesFactory facilitiesFactory;
        private Road road;
        private Building building;
        private Tunnel tunnel;
        private Jungle jungle;

        public GameManager(FacilitiesFactory facilitiesFactory)
        {
            this.facilitiesFactory = facilitiesFactory;
        }

        /// <summary>
        /// 创建设施
        /// </summary>
        public void BuildGameFacilities()
        {
            //这些方法的调用都是依赖抽象方法
            road = facilitiesFactory.CreateRoad();
            building = facilitiesFactory.CreateBuilding();
            tunnel = facilitiesFactory.CreateTunnel();
            jungle = facilitiesFactory.CreateJungle();
        }

        /// <summary>
        /// 运行游戏
        /// </summary>
        public void Run()
        {
            //road.AAA();
            //building.BBB(road);
            //tunnel.CCC();
            //jungle.DDD();
        }
    }
}
