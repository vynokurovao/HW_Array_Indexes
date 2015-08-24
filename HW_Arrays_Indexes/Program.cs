using System;

namespace HW_Arrays_Indexes_task1
{
    class Program
    {
        public static void DisplayInformation(MyMatrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write(String.Format("{0} ", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(5, 12);
            DisplayInformation(matrix);
            matrix.Rows = 2;
            DisplayInformation(matrix);
            Console.ReadKey();
        }
    }
}
