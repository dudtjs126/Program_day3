namespace parameter
{
    internal class Program
    {
        static void printLine()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();
        }


        static void printLine2(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();
        }


        static int Add(int a, int b)
        {
            return a + b;
        }

        // --------------------------------------------
        static float AddNumbers(float a, float b)
        {
            return a + b;
        }


        static int AddNumbers (int a, int b)
        {
            return a + b;
        }


        static int AddNumbers (int a, int b, int c)
        {
            return a + b + c;
        }
        //----------------------------------------------

        static void Main(string[] args)
        {
            printLine();
            printLine2(20);
            int result = Add(10, 20);
            Console.WriteLine(result);


            //------------------------------------------
            int sum1 = AddNumbers(10, 20);
            float sum2 = AddNumbers(10.5f, 21.5f);
            int sum3 = AddNumbers(10, 20, 30);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            //-------------------------------------------
        }
    }
}
