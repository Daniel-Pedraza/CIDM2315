namespace Homework3._3;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                if (row >= col)
                
                    Console.Write('*');
                
            }
            Console.WriteLine("");
        }
    }
}

