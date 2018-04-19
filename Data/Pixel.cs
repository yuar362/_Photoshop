using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class Pixel
    {
        double r;
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value < 0 || value > 1)
                    throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", value));
                r = value;
            }
        }

        double g;
        public double G
        {
            get
            {
                return g;
            }
            set
            {
                if (value < 0 || value > 1)
                    throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", value));
                g = value;
            }
        }

        double b;
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value < 0 || value > 1)
                    throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", value));
                b = value;
            }
        }
    }
}
