using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class GrayScaleFilter : PixelFilter<EmptyParameters>
    {
        public override string ToString()
        {
            return "Оттенки серого";
        }

        public override Pixel ProcessPixel(Pixel original, EmptyParameters parameters_)
        {
            var lightness = original.R + original.G + original.B;
            lightness *= 0.3333;
            return new Pixel(lightness, lightness, lightness);
        }
    }
}
