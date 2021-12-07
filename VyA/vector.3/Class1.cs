using System;

namespace vector._3
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
        public double DotProduct(Vector v){
            double res = (v.x * x)+(v.y * y);
            return res;
        }
        public double AngleBetween(Vector v){
            double mags = Magnitude()*v.Magnitude();
            double res = DotProduct(v)/mags;
            mags = Math.Acos(res);
            return mags;
        }
    }
}
