using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building();
            b1.BuildingHeight = 50;
            b1.EntrancesCount = 2;
            b1.FlatsCount = 30;
            b1.FloorsCount = 5;
            b1.Number = 1;
            b1.FloorHeight(25);

            Building b2 = Creator.CreateBuild();
            Console.WriteLine(b2);
            Building b3 = Creator.CreateBuild(60, 6, 600, 10);
        }
    }
}
