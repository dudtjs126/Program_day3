namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 숙제 1번
            /*{
                Random random = new Random();
                int number = random.Next(1, 101);
                int count = 0;

                Console.WriteLine("숫자 맞추기 게임을 시작합니다. 1에서 100까지의 숫자 중 하나를 맞춰보세요.");

                while (true)
                {
                    Console.Write("숫자를 입력하세요: ");
                    int playerNumber = int.Parse(Console.ReadLine());
                    count++;

                    if (playerNumber < number)
                    {
                        Console.WriteLine("너무 작습니다!");
                    }
                    else if (playerNumber > number)
                    {
                        Console.WriteLine("너무 큽니다!");
                    }
                    else
                    {
                        Console.WriteLine("축하합니다!  {0}번 만에 숫자를 맞추었습니다.", count);
                        break;
                    }
                }
            }*/



            // 숙제 2번
            {
                Console.WriteLine("플레이어 1: X 와 플레이어 2: O\n");
                Console.WriteLine("플레이어 1의 차례\n");

                int[,] arrange = new int[9, 17] 
                {
                    {0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0},
                    { 0, 0, 1, 0, 0, 10, 0, 0, 2, 0, 0, 10, 0, 0, 3, 0, 0},
                    { 11, 11, 11, 11, 11, 10, 11, 11, 11, 11, 11, 10, 11, 11, 11, 11, 11},
                    { 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0},
                    { 0, 0, 4, 0, 0, 10, 0, 0, 5, 0, 0, 10, 0, 0, 6, 0, 0},
                    { 11, 11, 11, 11, 11, 10, 11, 11, 11, 11, 11, 10, 11, 11, 11, 11, 11},
                    { 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0},
                    { 0, 0, 7, 0, 0, 10, 0, 0, 8, 0, 0, 10, 0, 0, 9, 0, 0},
                    { 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0}
                };

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        if (arrange[i,j] == 0)
                        {
                            Console.Write(" ");
                        }
                        else if (arrange[i,j] < 10)
                        {
                            Console.Write(arrange[i,j]);
                        }
                        else
                        {
                            if (arrange[i,j] == 10)
                            {
                                Console.Write("|");
                            }
                            else
                            {
                                Console.Write("_");
                            }
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
