using System;

namespace Geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Start of Point Menu */
            Console.WriteLine("******************* POINT ****************");
            //init of Points
            Point A = new Point(3, -2);
            Point B = new Point(2, -2);
            Point C = new Point(3, -1);
            Point D = new Point(2, -1);

            //Calc distnace between 2 points
            Console.WriteLine("distance between the 2 points is {0}", A.Distance(B));

            //checking dist
            //A.Equality(B) ? Console.WriteLine("The 2 Points Are equal!") : Console.WriteLine("The 2 Points Are NOT equal");
            Console.WriteLine(A.isEqualTo(B));

            //Transalation
            B.Translation(5, 8);
            Console.WriteLine("{0} {1}", B.X, B.Y);

            //Linear Check
            Console.WriteLine(A.isLinearWith(B, C));

            Console.WriteLine("***********************************\n");
            /*End Of Point Menu */





            /* Start of Droite Menu */
            Console.WriteLine("******************* DROITE ****************");
            //init of Lines
            Droite Droite1 = new Droite(A, B);
            Droite Droite2 = new Droite(D, C);

            Console.WriteLine(Droite1.isEqualTo(Droite2));

            Console.WriteLine(Droite1.stateWith(Droite2));

            Console.WriteLine("***********************************");
            /*End Of Droite Menu */





            /* Start of Cercle Menu */
            Console.WriteLine("******************* Circle ****************");
            Circle Circle1 = new Circle(A, 10);
            Circle Circle2 = new Circle(B, 5);
            //Equality
            Console.WriteLine(Circle1.isEqualTo(Circle2));
            //Air
            Console.WriteLine(Circle1.Air);
            //Circonference
            Console.WriteLine(Circle2.Circonference);
            //intersection
            Console.WriteLine(Circle1.isIntersectedWith(Circle2));
            Console.WriteLine("***********************************");
            /*End Of Circle Menu */





            /* Start of Elipse Menu */
            Console.WriteLine("******************* Elipse ****************");
            //variables
            Elipse Elipse1 = new Elipse(B, 20, 10);
            //Air
            Console.WriteLine(Elipse1.Air);
            //Circonference
            Console.WriteLine(Elipse1.Circonference);
            Console.WriteLine("***********************************");
            /*End Of Elipse Menu */
        }
    }
}
