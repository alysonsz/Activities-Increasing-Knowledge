using System; 

class URI {

    static void Main(string[] args) { 

        double number = 0;
        number = double.Parse(Console.ReadLine());
        if(number >= 0 && number <= 25){
            Console.WriteLine("Intervalo [0,25]");
        }
        else if(number > 25.0 && number <= 50){
            Console.WriteLine("Intervalo (25,50]");
        }
        else if(number >= 50.1 && number <= 75){
            Console.WriteLine("Intervalo (50,75]");
        }
        else if(number >= 75.01 && number <= 100){
            Console.WriteLine("Intervalo (75,100]");
        }
        else if(number < 0 || number > 100){
            Console.WriteLine("Fora de intervalo");
        }

    }

}
