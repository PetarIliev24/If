using System;

namespace _05.Fox
{
    class Fox
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int width = 2 * N + 3;

            int left = 1;
            int right = width - 2;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == left)
                    {
                        Console.Write("\\");
                    }
                    else if (col == right)
                    {
                        Console.Write("/");
                    }
                    else if (col > left && col < right)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                left++;
                right--;
                Console.WriteLine();
            }

            int middleHeight = N / 3;
            int offset = N / 2 + 1;
            left = offset;
            right = width - 1 - offset;

            for (int row = 0; row < middleHeight; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == 0 || col == width - 1)
                    {
                        Console.Write("|");
                    }
                    else if (col == left)
                    {
                        Console.Write("\\");
                    }
                    else if (col == right)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                left++;
                right--;
                Console.WriteLine();
            }

            left = 1;
            right = width - 2;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == left)
                    {
                        Console.Write("\\");
                    }
                    else if (col == right)
                    {
                        Console.Write("/");
                    }
                    else if (col > left && col < right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                left++;
                right--;
                Console.WriteLine();
            }


        }
    }
}
