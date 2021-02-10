using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w04
{
    class Building
    {
        private string buildingCode;
        private string buildingName;
        private string buildingLat;
        private string buildingLong;
        public Building(string bc,string bn,string lat,string lg)
        {
            this.buildingCode = bc;
            this.buildingName = bn;
            this.buildingLat = lat;
            this.buildingLong = lg;
        }
        public Building() { }
        public Building(string bc)
        {
            this.buildingCode = bc;
        }
        public string detail()
        {
            return "at Building code: " + this.buildingCode;
        }
        public override string ToString()
        {
            return "Building Code: "+this.buildingCode+"\tBuilding Name: "+this.buildingName+"\tBuilding Latitude: "+this.buildingLat+"\tBuilding Longtitude: "+this.buildingLong;
        }
    }
}
