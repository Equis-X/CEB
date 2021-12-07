using System;

namespace vector._1
{
    public class Vector
    {
        private int x {get;set;}
        private int y {get;set;}

        // Constructor
        public Vector(int x, int y){
            this.x = x;
            this.y = y;
        }

        // Methods - functions
        public double Magnitude(){
            double res = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
            return res;
        }
    }
}
