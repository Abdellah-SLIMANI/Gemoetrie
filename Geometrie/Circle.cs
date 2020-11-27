using System;

namespace Geometrie
{
    class Circle : Elipse
    {
        double radius { get => bigRadius; set { bigRadius = SmallRadius = value; } }

        //Constructor
        public Circle(Point c, double r) : base(c, r, r) { }

        //Equality
        public bool isEqualTo(Circle C)
        {
            bool isEqual = false;
            if (C.radius == this.radius && C.center.Distance(this.center) == 0)
                isEqual = true;
            return isEqual;
        }

        //Air
        public override double Air => base.Air;

        //Circonference
        public override double Circonference  
        {
            get
            {
                return Math.PI * 2 * radius;
            }
        }

        //intersection
        public bool isIntersectedWith(Circle C)
            {
                double distance = this.center.Distance(C.center);
                if (this.isEqualTo(C) ||  distance > this.radius + C.radius || distance < Math.Abs(this.radius - C.radius))
                    return false;
                return true;
            }
        }
}
