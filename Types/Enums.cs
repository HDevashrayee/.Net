using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    internal class Enums
    {
        //An Enum type defines a set of constant values.
        public enum SomeRootVegetable
        {
            HorseRadish,
            Radish,
            Turnip
        }

        [Flags]
        public enum Seasons
        {
            None = 0,
            Summer = 1,
            Autumn = 2,
            Winter = 4,
            Spring = 8,
            All = Summer | Autumn | Winter | Spring
        }

        private void main()
        {
            var turnip = SomeRootVegetable.Turnip;

            var spring = Seasons.Spring;
            var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
            var theYear = Seasons.All;
        }
    }
}
