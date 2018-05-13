using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {
        public Pixel(double r_, double g_, double b_)
        {
            r = g = b = 0;  //К свойствам нельзя обращаться пока не заполнены все поля. костыль чтобы работало.
            R = r_;
            G = g_;
            B = b_;
        }

        double check(double value_)
        {
            if (value_ < 0 || value_ > 1)
                throw new Exception(string.Format("The value must be between 0 and 1", value_));
            return value_;
        }

        static public double trim(double value_)
        {
            if (value_ < 0) value_ = 0;
            if (value_ > 1) value_ = 1;
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
            get { return g; }
            set { g = check(value); }
        }

        double b;
        public double B
        {
            get { return b; }
            set { b = check(value); }
        }

        static public Pixel operator *(Pixel pixel_, double number_)
        {
            return new Pixel(Pixel.trim(pixel_.R * number_), Pixel.trim(pixel_.G * number_), Pixel.trim(pixel_.B * number_));
        }

        static public Pixel operator *(double number_, Pixel pixel_)
        {
            return pixel_*number_;
        }
    }
}
