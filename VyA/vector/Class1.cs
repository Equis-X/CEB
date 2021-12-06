﻿using System;

namespace vector
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

        // Functions \ Methods
        public double Magnitude(){
            double temp = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
            return temp;
        }
    }
}
