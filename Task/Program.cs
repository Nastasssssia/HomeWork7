using MyLib;
namespace Task;
class Program
{
    static void Main(string[] args)
    {
       void Task47()
       {
        //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
        int rows = MyLibClass.Input("Введите размер строк: ");
        int columns = MyLibClass.Input("Введите размер столбцов: ");
        double[,] matrix = new double[rows, columns];
        MyLibClass.FillArray(matrix);
        MyLibClass.PrintArray(matrix);

       }

       void Task50()
       {
        //Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
        int rows = MyLibClass.Input("Введите размер строк: ");
        int columns = MyLibClass.Input("Введите размер столбцов: ");
        double[,] matrix = new double[rows, columns];
        MyLibClass.FillArray(matrix);
        MyLibClass.PrintArray(matrix);
        int i = MyLibClass.Input("Введите индекс строки искомого элемента: ");
        int j = MyLibClass.Input("Введите индекс столбца искомого элемента: ");
        if( i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
        {
            Console.WriteLine(matrix[i,j]);
        }
        else Console.WriteLine("Искомого элемента не существует в текущем массиве");
       }

       void Task52()
       {
            //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            int rows = MyLibClass.Input("Введите размер строк: ");
            int columns = MyLibClass.Input("Введите размер столбцов: ");
            int[,] matrix = new int[rows, columns];
            MyLibClass.FillArray(matrix,1,7);
            MyLibClass.PrintArray(matrix);
            for(int j =0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i,j];
                }
                if(matrix.GetLength(0) != 0)
                {
                double awg = (double) sum / matrix.GetLength(0); 
                Console.WriteLine($"Сумма столбца {j +1} = {sum}, среднее арифметическое столбца = {awg}");
                }
                else Console.WriteLine(" Ошибка ввода");
            }
            
        }
     
}
}
