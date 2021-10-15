using System;

namespace Test_c_
{

    class Program
    {

        static void Main(string[] args)
        {
            double[] centerPoint = new double[] { 0, -1.84, 5.859375 };
            double[,,] positionsArrays = new double[2, 5, 3];
            double[] gap = new double[2];
            double[] newPoint = new double[3];

            gap[0] = 1.125;
            gap[1] = 0.647;

            positionsArrays[0, 2, 0] = centerPoint[0];
            positionsArrays[0, 2, 1] = centerPoint[1];
            positionsArrays[0, 2, 2] = centerPoint[2];
            positionsArrays[1, 2, 0] = centerPoint[0];
            positionsArrays[1, 2, 1] = centerPoint[1];
            positionsArrays[1, 2, 2] = centerPoint[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    positionsArrays[i, 2 - ((int)Math.Pow(-1, i) * (j + 1)), 0] = positionsArrays[i, 2, 0] + Math.Pow(-1, i) * (gap[0] * (j + 1));
                    positionsArrays[i, 2 - ((int)Math.Pow(-1, i) * (j + 1)), 1] = positionsArrays[i, 2, 1] + (gap[1] * (j + 1));
                    positionsArrays[i, 2 - ((int)Math.Pow(-1, i) * (j + 1)), 2] = positionsArrays[i, 2, 2];
                    positionsArrays[i, 2 + ((int)Math.Pow(-1, i) * (j + 1)), 0] = positionsArrays[i, 2, 0] - Math.Pow(-1, i) * (gap[0] * (j + 1));
                    positionsArrays[i, 2 + ((int)Math.Pow(-1, i) * (j + 1)), 1] = positionsArrays[i, 2, 1] - (gap[1] * (j + 1));
                    positionsArrays[i, 2 + ((int)Math.Pow(-1, i) * (j + 1)), 2] = positionsArrays[i, 2, 2];
                }
            }

            double[] points = new double[] { 4, 5, 6 };


            Console.WriteLine("Hello World!");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(positionsArrays[i, j, k] + "f,");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

        }
    }
}
