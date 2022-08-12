
    internal class Program

    {

        static void Main(string[] args)

        {


            int row, column, moves = 0;

            char player, changePlayer = 'X';

            char[,] table = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };



            while (true)

            {

                Console.Clear();

                Board(table);

                Console.WriteLine("Choose the row");

                row = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose the column");

                column = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Row " + row + " Column " + column);



                player = changePlayer;

                table[row, column] = player;



                if (changePlayer == 'X')

                {

                    changePlayer = 'O';

                }

                else

                {

                    changePlayer = 'X';

                }



                if (VictoryChecker(table))

                {

                    Console.WriteLine("The player " + player + " is the Winner!!");



                    break;

                }



                moves = moves + 1;



                if (moves == 9)

                {

                    Console.WriteLine("Draw");

                    break;

                }

            }



        }



        public static bool VictoryChecker(char[,] table)

        {

            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (table[i, 0] == table[i, 1] && table[i, 1] == table[i, 2] && table[i, 1] != ' ')

                {
                    return true;
                }
            }

            for (int i = 0; i < table.GetLength(1); i++)
            {
                if (table[0, i] == table[1, i] && table[1, i] == table[2, i] && table[1, i] != ' ')
                {
                    return true;
                }
            }

            for (int i = 0; i < table.GetLength(1); i++)
            {
                if (table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2] && table[1, i] != ' ')
                {
                   return true;
                }
                
            }
            for (int i = 0; i < table.GetLength(1); i++)
                if (table[0, 2] == table[1, 1] && table[1, 1] == table[2, 0] && table[1, i] != ' ')
            {
                return true;
            }
            return false;
        }



        public static void Board(char[,] table)



        {



            Console.WriteLine("__|_0_|_1_|_2_|");

            for (int i = 0; i < table.GetLength(0); i++)

            {

                //Console.Write("Row " + i + ": ");

                Console.Write(i + " | ");



                for (int j = 0; j < table.GetLength(1); j++)



                {

                    Console.Write(table[i, j]);

                    Console.Write(" | ");



                }



                Console.WriteLine();



            }

        }

    }

}
