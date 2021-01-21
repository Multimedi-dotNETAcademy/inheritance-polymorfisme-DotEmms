using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCilinder
{
    class Cilinder : Circle
    {
        private double _h;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        public Cilinder()
        {

        }
        public Cilinder(double x, double y, double r, double h)
            :base(x,y,r)
        {
            H = h;
        }
        public override string Data()
        {
            return base.Data();
        }
        public override double Acreage()
        {
            return base.Acreage();
        }
        public double Volume()
        {
            return 0.0;
        }
    }
}
