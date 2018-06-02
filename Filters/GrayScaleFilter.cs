using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class GrayScaleFilter : PixelFilter
    {
        public GrayScaleFilter() : base(new EmptyParameters()) { }

        public override string ToString()
        {
            return "Оттенки серого";
        }

        public override Pixel ProcessPixel(Pixel original, IParameters parameters_)
        {
            var lightness = original.R + original.G + original.B;
            lightness *= 0.3333;
            return new Pixel(lightness, lightness, lightness);
        }
    }
}
