using System;

    class Program
    {
        static void Main()
        {
            string firstLine = Console.ReadLine();
            string[] firstLineRipped = firstLine.Split(' ');
            int rows = int.Parse(firstLineRipped[0]);
            int columns = int.Parse(firstLineRipped[1]);
            int counter = 0;
            string readedRows;
            string[] readedRowsSplit = new string[rows * columns];
            string[,] content = new string[rows, columns];

        if (rows > 10 || columns > 10)
            {
                Console.Write(' ');
            }
            else
            {
                for (int a = rows; a > 0; a--)
                {
                    counter = 0;
                    readedRows = Console.ReadLine();
                    readedRowsSplit = readedRows.Split(' ');

                    foreach (string i in readedRowsSplit)
                    {
                        content[a - 1, counter] = i;
                        counter++;
                    }
                }


                for (int newColumn = 0; newColumn <= columns; newColumn++)
                {
                    for (int newRow = rows-1; newRow >= 0 ; newRow--)
                    {
                    try
                    {
                        Console.Write(content[newRow, newColumn] + ' ');
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                    }
                    Console.WriteLine();
                }
            }
        }     
    }


    
