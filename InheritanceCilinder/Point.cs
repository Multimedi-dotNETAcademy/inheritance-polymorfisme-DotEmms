﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCilinder
{
    class Point
    {
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        private double _y;

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Point()
        {

    }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual string Data()
        {
            return $"({X},{Y})";
        }
    }
}
