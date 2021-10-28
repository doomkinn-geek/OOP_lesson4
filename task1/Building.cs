using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Building
    {
        private uint _number;
        private uint _buildingHeight;
        private uint _floorsCount;
        private uint _flatsCount;
        private uint _entrancesCount;

        private static uint _lastBuildingNumber = 0;

        public uint Number 
        { 
            get => _number;
            set { _number = value; }
        }

        public uint BuildingHeight
        {
            get => _buildingHeight;
            set { _buildingHeight = value; }
        }

        public uint FloorsCount
        {
            get => _floorsCount;
            set { _floorsCount = value; }
        }
        public uint FlatsCount
        {
            get => _flatsCount;
            set { _flatsCount = value; }
        }
        public uint EntrancesCount
        {
            get => _entrancesCount;
            set { _entrancesCount = value; }
        }

        public Building()
        {
            return;
        }
    }
}
