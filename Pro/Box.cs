using System;

namespace Pro
{
     class Box
    {
        
        private int myVar;

        public int MyProperty { 
            get { return myVar; }
            set { myVar = value; }
        }
        private int width;
        private int height;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) width = value;
                else Console.WriteLine("양수를 입력해주세요!");
            }
        }
             public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
                else Console.WriteLine("양수를 입력해주세요!");
            }
        }
        
        public int Area
        {
            get { return this.Width * this.Height; }
        }

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}