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
            set { data[width_index, height_index] = value; } //��� ��� ������ Pixel ��������� (�� ��������� ��� � ������� �� �����) �� �������� setter
        }

        public Photo(int width_, int height_)
        {
            width = width_;
            height = height_;
            data = new Pixel[width, height];            
        }
	}
}

