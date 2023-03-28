namespace Homework10;
class Program
{
    public static void Main(string[] args)
    {
        // Test Q1
        int[] arr = {11,23,31,42,53};
        ArraySum(arr);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

    }
         
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public static void ArraySum(int[] int_array){
        //put your answer below
        int sum = 0;
        for(int i=0; i<int_array.Length; i++){
            sum += int_array[i];
        }





    }


    //Q2.1: given a 2d array, print all the odd elements (2 points)
     public static void PrintAllOddNumber(int[ , ] array_2d){
        //put your answer below
        foreach(int value in array_2d){
            if(value%2==1){
                Console.Write($"{value}");
            }
        }



       
    }
    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[ , ] array_2d){
        //put your answer below
        int total = 0;
    
    for (int i = 0; i < array_2d.GetLength(0); i++)
    {
        
        for (int j = 0; j < array_2d.GetLength(1); j++)
        {
            
            total += array_2d[i, j];
        }
    }
    return total;

       
    }

    
}
