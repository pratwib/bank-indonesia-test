namespace BITest
{
    static class Program
    {
        static void Main()
        {
            int n1 = 15;
            NumberDisplayer numberDisplayer = new NumberDisplayer();
            numberDisplayer.DisplayNumbersWithOkYes(n1);
            Console.WriteLine("====================");

            int n2 = 5;
            NumberPatternDisplayer numberPatternDisplayer = new NumberPatternDisplayer();
            numberPatternDisplayer.DisplayNumberPatternA(n2);
            Console.WriteLine("====================");
            numberPatternDisplayer.DisplayNumberPatternB(n2);
            Console.WriteLine("====================");
            numberPatternDisplayer.DisplayNumberPatternC(n2);
            Console.WriteLine("====================");
            numberPatternDisplayer.DisplayNumberPatternD(n2);
            Console.WriteLine("====================");

            int[] numbers = [12, 9, 13, 6, 10, 4, 7, 2];
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            int[] processedNumbers = arrayProcessor.ProcessArray(numbers);
            Console.WriteLine("[" + string.Join(", ", processedNumbers) + "]");
        }
    }
}