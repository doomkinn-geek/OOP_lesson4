using System;
using System.Collections.Generic;
using System.Text;

namespace Building
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

        private uint GenerateBuildingNumber()
        {
            return _lastBuildingNumber++;
        }
        public uint FloorHeight(uint _flatNumber)
        {
            try
            {
                uint res;
                
                uint _relativeApartmentNumber = _flatNumber % this.FlatsInEntrance();
                res = _relativeApartmentNumber / this.FlatsInFloor();
                if (_relativeApartmentNumber % this.FlatsInFloor() == 0)
                {
                    return res;
                }
                else
                {
                    return res++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                return 0;
            }
        }

        public uint FlatsInEntrance()
        {
            if(this.FlatsCount == 0)
            {
                return 0;
            }
            if(this.FloorsCount == 0)
            {
                return 0;
            }
            return this.FlatsCount / this.EntrancesCount;
        }

        public uint FlatsInFloor()
        {
            if(this.FlatsCount == 0)
            {
                return 0;
            }
            if(this.FloorsCount == 0)
            {
                return 0;
            }
            return this.FlatsInEntrance() / this.FloorsCount;
        }

        public Building()
        {
            _number = GenerateBuildingNumber();
        }
        public Building(uint buildingHeight, uint floorsCount, uint flatsCount, uint entrancesCount)
        {
            _number = GenerateBuildingNumber();
            _buildingHeight = buildingHeight;
            _floorsCount = floorsCount;
            _entrancesCount = entrancesCount;
        }
    }
}
