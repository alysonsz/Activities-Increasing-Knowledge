using System; 

class URI {

    static void Main(string[] args) { 
        int ehPrimo = 0;
        int cases = int.Parse(Console.ReadLine());
        while (cases != 0){
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num ; i++){
                if (num % i == 0){
                    ehPrimo = ehPrimo + 1;
                }
            }
            if (ehPrimo == 2){
                Console.WriteLine("{0} eh primo", num);
            }
            else{
                Console.WriteLine("{0} nao eh primo", num);
            }
            ehPrimo = 0;
            cases = cases - 1;
        }
    }

}
