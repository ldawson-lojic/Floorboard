using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojicFloorboard_FormsApp
{
    [Serializable]
    public class Points
    {
        public List<Point> _Points = new List<Point>();
        public void Add(Point point)
        {
            _Points.Add(point);
        }
    }
    [Serializable]
    public class Point
    {
        public enum PointType {
            Person,
            Part,
            Package,
            Other
        }
        public PointType Type;
        public string name;
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Point(double LO, double LA, string _name, string _type)
        {
            Longitude = LO;
            Latitude = LA;
            name = _name;
            if(_type == "Person")
            {
                Type = PointType.Person;
            }
            if (_type == "Part")
            {
                Type = PointType.Part;
            }
            if (_type == "Package")
            {
                Type = PointType.Package;
            }
            if (_type == "Other")
            {
                Type = PointType.Other;
            }
        }
        public Point(double LO, double LA, string _name, PointType _type) {
            Longitude = LO;
            Latitude = LA;
            name = _name;
            Type = _type;
        }
        public Point()
        {
            name = "";
            Type = PointType.Other;
            Longitude = 0;
            Latitude = 0;
        }
    }
}
