using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Building
{
    class Creator
    {
        public static Hashtable Hashes;      
        private static void AddToHashTable(Building building)
        {
            Hashes.Add(building.Number, "building");
        }
        static public Building CreateBuild()
        {
            Building b = new Building();
            AddToHashTable(b);
            return b;
        }
        static public Building CreateBuild(uint buildingHeight, uint floorsCount, uint flatsCount, uint entrancesCount)
        {
            Building b = new Building(buildingHeight, floorsCount, flatsCount, entrancesCount);
            AddToHashTable(b);
            return b;
        }
        static public void DeleteBuilding(uint number)
        {
            Hashes.Remove(Convert.ToString(number));
        }

        private Creator()
        {
            Hashes = new Hashtable();            
        }
    }
}
