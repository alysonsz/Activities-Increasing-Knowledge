using System; 

class URI {

    static void Main(string[] args) { 
        int quantify = int.Parse(Console.ReadLine());
        int aux = 0;
        int i = 0;
        int sum = 0;
        while(quantify != 0){
            string[] values = Console.ReadLine().Split();
            int num1 = int.Parse(values[0]);
            int num2 = int.Parse(values[1]);
            if (num1 > num2){
                aux = num1;
                num1 = num2;
                num2 = aux;
            }
            i = num1;
            while (i < num2 - 1){
                i = i + 1;
                if (i % 2 == 1){
                    sum = sum + i;
                }
                continue;
            }
            Console.WriteLine(sum);
            sum = 0;
            quantify = quantify - 1;
            }
        }
    }
