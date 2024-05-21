namespace BITest;

public class NumberPatternDisplayer
{
    public void DisplayNumberPatternA(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }

    public void DisplayNumberPatternB(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }

    public void DisplayNumberPatternC(int n)
    {
        int count = 1;
        bool isAscending = true;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (isAscending)
                {
                    Console.Write(count);
                    count++;
                }
                else
                {
                    Console.Write(count);
                    count--;
                }

                if (count == 1 || count == n)
                {
                    isAscending = !isAscending;
                }
            }

            Console.WriteLine();
        }
    }

    public void DisplayNumberPatternD(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j == 1)
                {
                    Console.Write(i + " ");
                }
                else if (j % 2 == 0)
                {
                    Console.Write(((j * n) - (i - 1)) + " ");
                }
                else
                {
                    Console.Write(((j * n) - (n - i)) + " ");
                }
            }

            Console.WriteLine();
        }
    }
}