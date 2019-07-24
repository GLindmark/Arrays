using System;

namespace ArraysProject {
    class Program {
        static void Main(string[] args)
        {
            int[] frames = new int[10];

            frames[0] = 10;
            frames[1] = 7;
            frames[2] = 5;
            frames[3] = 10;
            frames[4] = 9;
            frames[5] = 8;
            frames[6] = 10;
            frames[7] = 2;
            frames[8] = 6;
            frames[9] = 10;

            int total = 0;
            int index = 0;
            while (index < 10)
            {
                total = total + frames[index];
                index = index + 1;
            }


            Console.WriteLine($"Total is {total}");
        } 


    }
}
