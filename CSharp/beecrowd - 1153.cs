using System; 

class URI {

    static void Main(string[] args) { 
        int result = 1;
        int factorial = int.Parse(Console.ReadLine());
        for(int i = 1; i <= factorial; i++){
            result = result * i;
        }
        Console.WriteLine(result);

    }

}
