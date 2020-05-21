using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int XCoordinate, int YCoordinate, String name, String description, string imageName)
        {
            Location loc = new Location();
            loc.XCoordinate = XCoordinate;
            loc.YCoordinate = YCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _locations.Add(loc);
        }


        public Location LocationAt(int XCoordinate, int YCoordinate)
        {
            foreach(Location loc in _locations)
            {
                if (loc.XCoordinate == XCoordinate && loc.YCoordinate == YCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
