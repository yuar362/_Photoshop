using System;

namespace MyPhotoshop
{
    public struct Pixel
    {
        public double R;
        public double G;
        public double B;
    }

	public class Photo
	{
		public int width;
		public int height;
		public Pixel[,] data;
	}
}

