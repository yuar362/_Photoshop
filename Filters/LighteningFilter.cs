using System;

namespace MyPhotoshop
{
	public class LighteningFilter : PixelFilter
	{
        public LighteningFilter() : base(new LightningParameters()) { }

		public override string ToString ()
		{
			return "Осветление/затемнение";
		}

        public override Pixel ProcessPixel(Pixel original, IParameters parameters_) 
        {
            return original * (parameters_ as LightningParameters).Coefficient;
        }
	}
}

