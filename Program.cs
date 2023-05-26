using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_class
{
 
     abstract class Shape
    {
        public abstract double area();

    }
    
    class Circle :  Shape
    {
        private double redi;
        public Circle(double r)
        {

            redi = r;
        }
        public override double area()
        {
            return 3.141 * redi * redi;
        }

    }

    class Squre : Shape
    {
        private double lenght;
        public Squre(double l)
        {

            lenght =l;
        }
        public override double area()
        {
            return lenght * lenght; 


        }



    }

    class tringle : Shape

    {
        private int t_base;
        private  int t_height;

        public tringle(int b,int h)
        {
            t_base = b;
            t_height = h;
        }
        public override double area()
        {
            return 0.5 * t_base * t_height;
        }


    }
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            Circle c = new Circle(10.2);
            Console.WriteLine("circle  is : ");
            Console.WriteLine(c.area());
            Squre s = new Squre(30);
            Console.WriteLine("square is :");
            Console.WriteLine(s.area());

            tringle t = new tringle(20,30);
            Console.WriteLine("tringle is :" );
            Console.WriteLine(t.area());
;        }
    }
}
