using System;

namespace ReferenceVStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            cube c1 = new cube();
            c1.x = 10;
            c1.y = 12;
            c1.x = 14;

           // ProcessCube(c1);
            Cube c2;

            c2 = c1;

            c2.x = 1000;
            Console.WriteLine(c2.x);            //  classes are ref types c1 ref place in memory.  c1 is a pointer.  c2 now equals a pointer.
            Console.WriteLine(c1.x);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static void ProcessCube(Cube cu)
        {
            Console.WriteLine(cu.x);
            cu.x = 3333;
        }
    }

    class Cube
       
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }


 
    struct Cube
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }
}
