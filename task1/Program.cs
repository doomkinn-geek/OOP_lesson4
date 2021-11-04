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
            b1.FloorHeight(25);
            Console.WriteLine(b1);

            Building b2 = Creator.CreateBuild();
            Console.WriteLine(b2);
            Building b3 = Creator.CreateBuild(60, 6, 600, 10);
            Console.WriteLine(b3);
            Console.WriteLine($"Квартира номер 23 находится на {b3.FloorHeight(23)} этаже");
            Creator.DeleteBuilding(b3.Number);
        }
    }
}
