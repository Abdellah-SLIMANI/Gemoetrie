using System;

namespace Geometrie
{
    class Droite
    {
        //Varibales of type Point
        private Point p1, p2;

        //Constructeur
        public Droite(Point a, Point b)
        {
            p1 = a;
            p2 = b;
        }

        //Getter and Setter
        public Point P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public Point P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        //Equality
        public bool isEqualTo(Droite droite)
        {
            bool isEqual = false;
            if(this.p1.Distance(p2) == droite.p1.Distance(p2))
                isEqual = true;
            return isEqual;
        }

        //paralelizm, inters
        public string stateWith(Droite droite)
        {
            string state = "intersection";
            //Det
            double helper = (droite.P1.X * this.P2.Y) - (this.P1.X * droite.P2.Y);
            if(helper == 0)
            {
                state = "Paralelle";
            }
            return state;
        }
    }
}
