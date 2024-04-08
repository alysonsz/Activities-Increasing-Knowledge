using System; 

class URI {

    static void Main(string[] args) { 
        while(true){
            string[] numbers = Console.ReadLine().Split();
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            if(num1 == num2){
                break;
            }
            else if (num1 > num2){
                Console.WriteLine("Decrescente");
            }
            else if (num2 > num1){
                Console.WriteLine("Crescente");
            }
        }
    }
}
