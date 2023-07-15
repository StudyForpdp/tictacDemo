namespace TicTac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("             Assalomu alaykum Tic Tac oyiniga xush kelibsiz \n");
            Console.WriteLine("1-raqamli o'yinchi - x");
            Console.WriteLine("2-raqamli o'yinchi - o \n \n");

            Console.Write("1-raqamli o'yinchi ismingizni kiriting: ");
            string player1 = Console.ReadLine();

            Console.Write("2-raqamli o'yinchi ismingizni kiriting: ");
            string player2 = Console.ReadLine();

            string golib = "";
            char golibBelgisi;
            bool golibBormi = false;
            Console.Clear();


            char[,] tictacgame = {
                                   { '1', '2', '3' },
                                   { '4', '5', '6' },
                                   { '7', '8', '9' }
                                  };
            int[] numberList = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("                          O'yin boshlandi");
                Console.WriteLine($"              {player1} - x              {player2} - o \n \n");


                for (int s = 0; s < tictacgame.GetLength(0); s++)
                {
                    for (int j = 0; j < tictacgame.GetLength(1); j++)
                    {
                        Console.Write(tictacgame[s, j] + "   ");
                    }
                    Console.WriteLine();
                }

                int playerNumberInput;
                while (true)
                {
                    bool numCheck = false;
                    if (i % 2 == 0 && i != 1)
                    {
                        Console.Write($"{player1} ");
                    }
                    else
                    {
                        Console.Write($"{player2} ");
                    }
                    playerNumberInput = InputNumber();
                    if (playerNumberInput == 0 || playerNumberInput > 9)
                    {
                        Console.WriteLine("Iltimos mavjud sonlardan birini tanlang!");
                        continue;
                    }
                    for (int b = 0; b < numberList.GetLength(0); b++)
                    {
                        if (playerNumberInput == numberList[b])
                        {
                            numCheck = true;
                            break;
                        }
                    }

                    if (numCheck)
                    {
                        Console.WriteLine("Iltimos mavjud sonlardan birini tanlang!");
                        continue;
                    }
                    numberList[i] = playerNumberInput;
                    break;
                }

                if (i % 2 == 0 && i != 1)
                {
                    switch (playerNumberInput)
                    {
                        case 1:
                            tictacgame[0, 0] = 'x';
                            break;
                        case 2:
                            tictacgame[0, 1] = 'x';
                            break;
                        case 3:
                            tictacgame[0, 2] = 'x';
                            break;
                        case 4:
                            tictacgame[1, 0] = 'x';
                            break;
                        case 5:
                            tictacgame[1, 1] = 'x';
                            break;
                        case 6:
                            tictacgame[1, 2] = 'x';
                            break;
                        case 7:
                            tictacgame[2, 0] = 'x';
                            break;
                        case 8:
                            tictacgame[2, 1] = 'x';
                            break;
                        case 9:
                            tictacgame[2, 2] = 'x';
                            break;
                        default: break;
                    }
                }

                if (i % 2 != 0 || i == 1)
                {
                    switch (playerNumberInput)
                    {
                        case 1:
                            tictacgame[0, 0] = 'o';
                            break;
                        case 2:
                            tictacgame[0, 1] = 'o';
                            break;
                        case 3:
                            tictacgame[0, 2] = 'o';
                            break;
                        case 4:
                            tictacgame[1, 0] = 'o';
                            break;
                        case 5:
                            tictacgame[1, 1] = 'o';
                            break;
                        case 6:
                            tictacgame[1, 2] = 'o';
                            break;
                        case 7:
                            tictacgame[2, 0] = 'o';
                            break;
                        case 8:
                            tictacgame[2, 1] = 'o';
                            break;
                        case 9:
                            tictacgame[2, 2] = 'o';
                            break;
                        default: break;
                    }
                }

                if (i >= 4)
                {
                    if ((tictacgame[0, 0] == tictacgame[0, 1] && tictacgame[0, 1] == tictacgame[0, 2]) ||
                    (tictacgame[1, 0] == tictacgame[1, 1] && tictacgame[1, 1] == tictacgame[1, 2]) ||
                    (tictacgame[2, 0] == tictacgame[2, 1] && tictacgame[2, 1] == tictacgame[2, 2]) ||
                    (tictacgame[0, 0] == tictacgame[1, 0] && tictacgame[1, 0] == tictacgame[2, 0]) ||
                    (tictacgame[0, 1] == tictacgame[1, 1] && tictacgame[1, 1] == tictacgame[2, 1]) ||
                    (tictacgame[0, 2] == tictacgame[1, 2] && tictacgame[1, 2] == tictacgame[2, 2]) ||
                    (tictacgame[0, 0] == tictacgame[1, 1] && tictacgame[1, 1] == tictacgame[2, 2]) ||
                    (tictacgame[0, 2] == tictacgame[1, 1] && tictacgame[1, 1] == tictacgame[2, 0])
                    )
                    {
                        if (i % 2 == 0 && i != 1)
                        {
                            golib = player1;
                            golibBelgisi = 'x';
                            golibBormi = true;
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            golib = player2;
                            golibBelgisi = 'o';
                            golibBormi = true;
                            Console.Clear();
                            break;
                        }
                    }
                }
                Console.Clear();
            }



            if (golibBormi)
            {
                Console.WriteLine("                         O'yin tugadi !!! ");
                Console.WriteLine($"              {player1} - x              {player2} - o \n \n");
                for (int s = 0; s < tictacgame.GetLength(0); s++)
                {
                    for (int j = 0; j < tictacgame.GetLength(1); j++)
                    {
                        Console.Write(tictacgame[s, j] + "   ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"{golib} tabriklayman o'yinda g'alaba qozondingiz \n \n");
            }
            else
            {
                Console.WriteLine("                         O'yin tugadi !!! ");
                Console.WriteLine($"              {player1} - x              {player2} - o \n \n");
                for (int s = 0; s < tictacgame.GetLength(0); s++)
                {
                    for (int j = 0; j < tictacgame.GetLength(1); j++)
                    {
                        Console.Write(tictacgame[s, j] + "   ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("O'yinda g'olib aniqlanmadi natija durang \n \n");
            }
        }

        static int InputNumber()
        {
            Console.Write("raqamlardan birini tanlang: ");
            int a;

            if (!int.TryParse(Console.ReadLine(), out a))
            {

            }


            return a;
        }
    }
}