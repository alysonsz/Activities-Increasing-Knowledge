using System; 

class URI {

    static void Main(string[] args) { 

        int number = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 1; i <= 10; i++){
            result = number * i;
            Console.WriteLine("{0} x {1} = {2}", i, number, result);
        }
    }

}
