using System;

namespace MyPhotoshop
{
    public class Photo
	{
		public readonly int width;

		public readonly int height;
        
		private readonly Pixel[,] data;
        public Pixel this[int width_index, int height_index] 
        { 
            get { return data[width_index, height_index]; }
            set { data[width_index, height_index] = value; } //так как теперь Pixel структура (не ссылочный тип в отличии от класа) то добавили setter
        }

        public Photo(int width_, int height_)
        {
            width = width_;
            height = height_;
            data = new Pixel[width, height];            
        }
	}
}

