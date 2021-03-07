using System;
using System.Collections.Generic;
using System.Text;

namespace No03_Builder
{
    public class RomanHouse : House
    {

    }

    public class RomanDoor : Door { };
    public class RomanFloor : Floor { };
    public class RomanHouseCeiling : HouseCeiling { };
    public class RomanWall : Wall { };
    public class RomanWindows : Windows { };

    public class RomanHouseBuilder : Builder
    {
        public override void BuildDoor()
        {
            throw new NotImplementedException();
        }

        public override void BuildFloor()
        {
            throw new NotImplementedException();
        }

        public override void BuildHouseCeiling()
        {
            throw new NotImplementedException();
        }

        public override void BuildWall()
        {
            throw new NotImplementedException();
        }

        public override void BuildWindows()
        {
            throw new NotImplementedException();
        }

        public override House GetHouse()
        {
            throw new NotImplementedException();
        }
    }
}
