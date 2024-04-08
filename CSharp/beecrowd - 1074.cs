using System; 

class URI {

    static void Main(string[] args) { 

        int quantify = int.Parse(Console.ReadLine());
        while(quantify != 0){
            int number = int.Parse(Console.ReadLine());
            if (number == 0){
                Console.WriteLine("NULL");
            }
            if (Math.Abs(number) % 2 == 0){
                if (number > 0){
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (number < 0){
                    Console.WriteLine("EVEN NEGATIVE");
                }
            }
            else if (Math.Abs(number) % 2 == 1){
                if (number > 0){
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (number < 0){
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
            quantify = quantify - 1;
        }

    }

}
