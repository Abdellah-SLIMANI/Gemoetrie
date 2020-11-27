using System;

namespace Geometrie
{
    class Elipse
    {
        //variable
        protected Point center;
        protected double bigRadius;
        private double smallRadius;

        //Constructeur
        public Elipse(Point c, double r1 = 0, double r2 = 0)
        {
            center = new Point();
            center = c;
            bigRadius = r1;
            smallRadius = r2;
        }

        //Setters and Getters
        public Point Center
        { 
            get;
            set;
        }
        public double BigRadius
        {
            get => bigRadius;
            set
            {
                if (value < 0)
                    return;
                if(value < smallRadius)
                {
                    bigRadius = smallRadius;
                    smallRadius = value;
                }else 
                    bigRadius = value;
            }
        }

        public double SmallRadius
        {
            get => smallRadius;
            set
            {
                if (value < 0)
                    return;
                if (value > bigRadius)
                {
                    smallRadius = bigRadius;
                    bigRadius = value;
                }
                else smallRadius = value;
            }
        }

        //Air
        public virtual double Air 
        {
            get
            {
                return Math.PI * smallRadius * bigRadius;
            }
        }

        //Circonference
        public virtual double Circonference 
        {
            get 
            { 
               return Math.Sqrt(Math.Pow(bigRadius, 2) + Math.Pow(smallRadius, 2) / 2) * Math.PI * 2; 
            }
        }
    }
}
