using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCilinder
{
    class Circle : Point
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Circle()
        {

        }
        public Circle(double x, double y, double r)
            :base(x,y)
        {
            R = r; 
        }
        public override string Data() //gegevens
        {
            return base.Data();
        }
        public double Circumference() //omtrek
        {
            return 0.0;
        }
        public virtual double Acreage() //oppervlakte
        {
            return 0.0;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
