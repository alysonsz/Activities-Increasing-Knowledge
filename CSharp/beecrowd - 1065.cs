using System; 

class URI {

    static void Main(string[] args) { 
        int count = 0;
        for (int i = 0; i < 5; i++){
            int number = int.Parse(Console.ReadLine());
            if(Math.Abs(number) % 2 == 0){
                count = count + 1;
            }
        }
        Console.WriteLine("{0} valores pares", count);
    }

}
