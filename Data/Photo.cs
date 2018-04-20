using System;

namespace MyPhotoshop
{
    public class Photo
	{
		public readonly int width;

		public readonly int height;
        
		Pixel[,] data;
        public Pixel[,] Data { get { return data; } }

        public Photo(int width_, int height_)
        {
            width = width_;
            height = height_;
            data = new Pixel[width, height];
            for (int i = 0; i < width; ++i)
                for (int j = 0; j < height; ++j)
                    data[i, j] = new Pixel();
        }
	}
}

