using System; 

class URI {

    static void Main(string[] args) { 

        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int sum = 0;
        int aux = 0;
        if (num1 > num2){
            aux = num2;
            num2 = num1;
            num1 = aux;
        }
        while(num1 <= num2){
            if (num1 % 13 != 0){
                sum = sum + num1;
            }
            num1 = num1 + 1;
        }
        Console.WriteLine(sum);

    }

}
