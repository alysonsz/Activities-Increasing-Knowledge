using System;
using System.Text.RegularExpressions;

class URI {

    static void Main(string[] args) { 
        int even = 0;
        int odd = 0;
        int positive = 0;
        int negative = 0;
        for (int i = 0; i < 5; i++){
            int num = int.Parse(Console.ReadLine());
            if (num < 0){
                negative = negative + 1;
            }
            if (num > 0){
                positive = positive + 1;
            }
            if (Math.Abs(num) % 2 == 0){
                even = even + 1;
            }
            if (Math.Abs(num) % 2 == 1){
                odd = odd + 1;
            }
        }
        Console.WriteLine("{0} valor(es) par(es)\n{1} valor(es) impar(es)\n{2} valor(es) positivo(s)\n{3} valor(es) negativo(s)", even, odd, positive, negative);
    }

}
