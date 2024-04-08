using System; 

class URI {

    static void Main(string[] args) { 

        int aux = 0;
        int odd = 0;
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        if (num2 > num1){
            aux = num1;
            num1 = num2;
            num2 = aux;
        }
        for (int i = num2 + 1; i < num1; i++){
            if (Math.Abs(i) % 2 == 1){
                odd = odd + i;
            }
        }
        Console.WriteLine(odd);
    }
}
