using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building build = new Building("lennian 65", 12, 33, 32);
            MuiltiBuilding mbuild = new MuiltiBuilding("lennian 67", 5, 5, 33, 5);


            build.Print();
            mbuild.Print();

            Console.ReadKey();
        }

    }


    class Building
    {

        public string Address { get; set; }
        public int Length { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Building(string address, int length, int width, int height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Адрес:{0} Длина: {1} Ширина: {2} Высота: {3}", Address, Length, Width, Height);
        }

    }


    sealed class MuiltiBuilding : Building
    {
        public int Levels { get; set; }
        public MuiltiBuilding(string address, int length, int width, int height, int levels) : base(address, length, width, height)
        {
            Levels = levels;
        }


        public new void Print()
        {
            Console.Write("Многоэтжаное здание {0} этажей ", Levels);
            base.Print();
        }

    }

}
