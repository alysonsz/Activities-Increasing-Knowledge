using System; 

class URI {

    static void Main(string[] args) { 
        int result = 0;
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number + 1; i++){
            if (i % 2 == 0){
                result = i * i;
                Console.WriteLine("{0}^2 = {1}", i, result);
            }
        }

    }

}
