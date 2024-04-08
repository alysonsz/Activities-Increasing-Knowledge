using System; 

class URI {

    static void Main(string[] args) { 
        int quantify = 0;
        int sum = 0;
        int num1 = int.Parse(Console.ReadLine());
        while(true){
            int num2 = int.Parse(Console.ReadLine());
            if (num2 > num1){
                while (num2 > sum){
                    sum = sum + num1;
                    num1 = num1 + 1;
                    quantify = quantify + 1;
                }
                break;
            }
        }
        Console.WriteLine(quantify);
    }

}
