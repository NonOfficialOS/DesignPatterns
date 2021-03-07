using System;
using System.Collections.Generic;
using System.Text;

namespace No02_AbstractFactory.AbstractFactoyGame
{
    /// <summary>
    /// 道路
    /// </summary>
    public abstract class Road
    {
    }

    /// <summary>
    /// 建筑屋
    /// </summary>
    public abstract class Building
    {
    }

    /// <summary>
    /// 隧道
    /// </summary>
    public abstract class Tunnel
    {
    }

    /// <summary>
    /// 丛林
    /// </summary>
    public abstract class Jungle
    {

    }

    /// <summary>
    /// 设施
    /// </summary>
    public abstract class FacilitiesFactory
    {
        public abstract Road CreateRoad();
        public abstract Building CreateBuilding();
        public abstract Tunnel CreateTunnel();
        public abstract Jungle CreateJungle();
    }
}
