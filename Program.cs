using System;
namespace pr
{
    class Program
    {
        static void Main()
        {
            int imax = 19;
            int imin = 0;
            bool flag = true;
            int[] array = new int[20];
            Random rnd = new Random();
            int buf;
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(3, 40);
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();

            for (int j = 0; j < 20; j++)
            {
                if (flag)
                {

                    for (int m = imax; m >= imin + 1; m--)
                    {
                        if (array[m] <= array[m - 1])
                        {
                            buf = array[m];
                            array[m] = array[m - 1];
                            array[m - 1] = buf;
                        }
                    }
                    imin++;
                    flag = false;
                }
                else
                {
                    for (int m = imin; m <= imax - 1; m++)
                    {
                        if (array[m] <= array[m + 1])
                        {
                            buf = array[m];
                            array[m] = array[m + 1];
                            array[m + 1] = buf;
                        }
                    }
                    imax--;
                    flag = true;
                }




            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write(array[i] + "  ");
            }
            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
    }
}

