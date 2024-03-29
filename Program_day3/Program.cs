﻿namespace Program_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열 기초
            {
                Console.WriteLine("1. 배열 기초");
                int[] itemPrices = { 100, 200, 300, 400, 500 };
                int totalPrice = 0;

                for (int i = 0; i < itemPrices.Length; i++)
                {
                    totalPrice += itemPrices[i];
                }

                Console.WriteLine("총 아이템 가격: " + totalPrice + "gold");
            }



            // 게임 캐릭터의 능력치 배열 만들기
            {
                Console.WriteLine("\n\n2. 게임 캐릭터의 능력치 배열 만들기");
                int[] playerStats = new int[4];

                Random rand = new Random();
                for (int i = 0; i < playerStats.Length; i++)
                {
                    playerStats[i] = rand.Next(1, 11);
                }

                Console.WriteLine("플레이어의 공격력: " + playerStats[0]);
                Console.WriteLine("플레이어의 방어력: " + playerStats[1]);
                Console.WriteLine("플레이어의 체력: " + playerStats[2]);
                Console.WriteLine("플레이어의 스피드: " + playerStats[3]);
            }



            // 학생들의 성적 평균 구하기
            {
                Console.WriteLine("\n\n3. 학생들의 성적 평균 구하기");
                int[] Scores = new int[5];

                for (int i = 0; i < Scores.Length; i++)
                {
                    Console.Write("학생 " + (i + 1) + " 의 성적을 입력하세요: ");
                    Scores[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;

                for (int i = 0; i < Scores.Length; i++)
                {
                    sum += Scores[i];
                }

                double average = (double)sum / Scores.Length;
                Console.WriteLine("성적 평균은 " + average + " 입니다.");
            }



            // 배열을 활용한 숫자 맞추기 게임
            {
                // 컴퓨터가 랜덤값 3개를 지정
                Random random = new Random();
                int[] numbers = new int[3];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = random.Next(1, 10);
                }


                // 플레이어가 값을 입력
                int attempt = 0;

                while (true)
                {
                    Console.Write("3개의 숫자를 입력하세요 (1~9): ");
                    int[] guesses = new int[3];

                    for (int i = 0; i < guesses.Length; i++)
                    {
                        guesses[i] = int.Parse(Console.ReadLine());
                    }


                    int correct = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        for (int j = 0; j < guesses.Length; j++)
                        {
                            if (numbers[i] == guesses[j])
                            {
                                correct++;
                                break;
                            }
                        }
                    }

                    attempt++;
                    Console.WriteLine("시도 #" + attempt + " : " + correct + "개의 숫자를 맞추셨습니다.");

                    if (correct == 3)
                    {
                        Console.WriteLine("축하합니다! 모든 숫자를 맞추셨습니다.");
                        break;
                    }
                }
            }



            // 다차원 배열 기초
            {
                int[,] map = new int[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        map[i, j] = i + j;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(map[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }



            // 2차원 배열을 사용하여 게임 맵을 구현
            {
                int[,] map = new int[5, 5]
                {
                    { 1, 1, 1, 1, 1},
                    { 0, 1, 1, 0, 1},
                    { 1, 1, 1, 1, 1},
                    { 1, 0, 0, 0, 1},
                    { 1, 0, 1, 0, 1}
                };

                for (int i = 0; i<5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (map[i, j] == 1)
                        {
                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write("□");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
