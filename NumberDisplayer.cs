namespace BITest;

class NumberDisplayer
{
    public void DisplayNumbersWithOkYes(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                Console.WriteLine("OKYES");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("OK");
            }
            else if (i % 4 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}