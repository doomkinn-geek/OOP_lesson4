using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b = new Building();
            b.BuildingHeight = 50;
            b.EntrancesCount = 2;
            b.FlatsCount = 30;
            b.FloorsCount = 5;
            b.Number = 1;
            b.FloorHeight(25);
        }
    }
}
