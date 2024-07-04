using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_15
{
    struct Point
    {
		private double x;
		private double y;

        //constructor to intialize the property
        public Point(double _x , double _y)
        {
            this.x=_x;
            this.y=_y;
        }

        //property for x
        public double X
		{
			get { return x; }
			set { x = value; }
		}

        //proparty for y
        public double Y
        {
            get { return y; }
            set { y = value; }
        }


    }
}
