using System;


namespace Geometrie
{
    class Point
    {
        //Variables
        private double x, y;

        //constructeur
        public Point(double px = 0, double py = 0) => (x, y) = (px, py);

        //Setter and Getter
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        
        //Distance
        public double Distance(Point p)
        {
            double distance = Math.Sqrt(Math.Pow((this.x - p.x), 2) + Math.Pow((this.y - p.y), 2));
            return distance;
        }

        //Equality 
        //using the previous Distance methode here with the point given on the params 
        public bool isEqualTo(Point p) => this.Distance(p) == 0;
            
        //Translation 
        public void Translation(double x = 0, double y = 0)
        {
            Console.WriteLine("Your Point has been transalted from {0};{1} to {2};{3}", this.X, this.Y, this.X + x, this.Y + y);
            this.X += x;
            this.Y += y;
        }

        //Linearity
        public bool isLinearWith(Point p1, Point p2)
        {
            bool isLinear = false;
            if ((p1.Y - this.Y)/(p1.X - this.X) == (p2.Y - this.Y)/(p2.X - this.X))
            {
                isLinear = true;
                return isLinear;
            }
            return isLinear;
        }
    }
}
