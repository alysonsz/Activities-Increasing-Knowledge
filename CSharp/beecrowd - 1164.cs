using System; 

class URI {

    static void Main(string[] args) { 
        int sum = 0;
        int cases = int.Parse(Console.ReadLine());
        while (cases != 0){
            int num = int.Parse(Console.ReadLine());
                for (int i = 1; i < num; i++){
                    if (num % i == 0){
                        sum = sum + i;
                    }
            }
            if (sum == num){
                Console.WriteLine("{0} eh perfeito", num);
                
            }
            else{
                Console.WriteLine("{0} nao eh perfeito", num);
            }
            sum = 0;
            cases = cases - 1;
        }

    }

}
