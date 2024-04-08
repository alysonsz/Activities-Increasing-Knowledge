using System; 

class URI {

    static void Main(string[] args) { 
        int aux = 0;
        string[] numbers = Console.ReadLine().Split();
        int number1 = int.Parse(numbers[0]);
        int number2 = int.Parse(numbers[1]);
        int number3 = int.Parse(numbers[2]);
        int oldnumber1 = number1;
        int oldnumber2 = number2;
        int oldnumber3 = number3;
        while (number1 > number2 || number2 > number3 || number1 > number3){
            if (number1 > number2){
                aux = number1;
                number1 = number2;
                number2 = aux;
            }
            if (number2 > number3){
                aux = number2;
                number2 = number3;
                number3 = aux;
            }
            if (number1 > number3){
                aux = number1;
                number1 = number3;
                number3 = aux;
            }
        }
        Console.WriteLine("{0}\n{1}\n{2}\n", number1, number2, number3);
        Console.WriteLine("{0}\n{1}\n{2}", oldnumber1, oldnumber2, oldnumber3);
    }

}
