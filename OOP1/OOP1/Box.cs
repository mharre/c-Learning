using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Box
    {
        // member variables
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        // PROPERTIES

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        public int Width { get; set; }
        // same as height but much shorter
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        //constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        // setters and getters (change private stuff)
        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            // not giving volume directly, just giving a calculation
            return this.length * this.height * this.Width;
        }

        public void DisplayInfo()
        {
            volume = length * Width * height;
            Console.WriteLine($"L = {length}, W = {Width}, h = {height}, v = {volume}");
        }


    }
}
