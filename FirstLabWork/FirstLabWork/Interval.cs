using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalSpace
{
    public class Interval
    {
        private double leftEdge;
        private double rightEdge;
        public double LeftEdge 
        {
            get { return leftEdge; }
            set { leftEdge = value; }
        }
        public double RightEdge
        {
            get { return rightEdge; }
            set { rightEdge = value; }
        }
        public Interval()
        {
            rightEdge = 0;
            leftEdge = 0;
        }
        public Interval(double leftEdge, double rightEdge)
        {
            if (leftEdge > rightEdge)
            {
                this.leftEdge = rightEdge;
                this.rightEdge = leftEdge;
            }            
            else
            {
                this.leftEdge = leftEdge;
                this.rightEdge = rightEdge;
            }
        }
    }
}
