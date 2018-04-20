﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class Pixel
    {
        double check(double value_)
        {
            if (value_ < 0 || value_ > 1)
                throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", value_));
            return value_;
        }

        double r;
        public double R
        {
            get { return r; }
            set { r = check(value); }
        }

        double g;
        public double G
        {
            get { return r; }
            set { g = check(value); }
        }

        double b;
        public double B
        {
            get { return r; }
            set { b = check(value); }
        }
    }
}
