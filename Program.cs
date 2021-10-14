using System;

namespace Test_c_
{

    class Program
    {

        static void Main(string[] args)
        {
            double[] centerPoint = new double[] { 0, -1.84, 5.859375 };
            double[,,] positionsArrays = new double[5, 2, 3];
            double[] gap = new double[2];
            double[] newPoint = new double[3];

            gap[0] = 1.125f;
            gap[1] = 0.648f;

            positionsArrays[2, 0, 0] = centerPoint[0];
            positionsArrays[2, 0, 1] = centerPoint[1];
            positionsArrays[2, 0, 2] = centerPoint[2];
            positionsArrays[2, 1, 0] = centerPoint[0];
            positionsArrays[2, 1, 1] = centerPoint[1];
            positionsArrays[2, 1, 2] = centerPoint[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    positionsArrays[2 - ((int)Math.Pow(-1, i) * (j + 1)), i, 0] = positionsArrays[2, i, 0] + Math.Pow(-1, i) * (gap[0] * (j + 1));
                    positionsArrays[2 - ((int)Math.Pow(-1, i) * (j + 1)), i, 1] = positionsArrays[2, i, 1] + (gap[1] * (j + 1));
                    positionsArrays[2 - ((int)Math.Pow(-1, i) * (j + 1)), i, 2] = positionsArrays[2, i, 2];
                    positionsArrays[2 + ((int)Math.Pow(-1, i) * (j + 1)), i, 0] = positionsArrays[2, i, 0] - Math.Pow(-1, i) * (gap[0] * (j + 1));
                    positionsArrays[2 + ((int)Math.Pow(-1, i) * (j + 1)), i, 1] = positionsArrays[2, i, 1] - (gap[1] * (j + 1));
                    positionsArrays[2 + ((int)Math.Pow(-1, i) * (j + 1)), i, 2] = positionsArrays[2, i, 2];
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
                        Console.Write(positionsArrays[j, i, k] + ",");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

        }
    }
}
