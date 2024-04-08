using System; 

class URI {

    static void Main(string[] args) { 
        int aux = 0;
        int sum = 0;
        while(true){
            string[] values = Console.ReadLine().Split();
            int num1 = int.Parse(values[0]);
            int num2 = int.Parse(values[1]);
            if (num2 > num1){
                aux = num1;
                num1 = num2;
                num2 = aux;
            }
            if (num1 == 0 || num1 < 0 || num2 == 0 || num2 < 0){
                break;
            }
            else{
                for (int i = num2; i <= num1; i++){
                    Console.Write("{0} ", i);
                    sum = sum + i;
                }
            }
            Console.Write("Sum={0}\n", sum);
            sum = 0;
        }
    }
}
