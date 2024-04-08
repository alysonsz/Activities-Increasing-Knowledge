using System; 

class URI {

    static void Main(string[] args) { 
        int inRange = 0;
        int outRange = 0;
        int quantify = int.Parse(Console.ReadLine());
        while (quantify != 0){
            int number = int.Parse(Console.ReadLine());
            if (number >= 10 && number <= 20){
                inRange = inRange + 1;
            }
            else{
                outRange = outRange + 1;
            }
            quantify = quantify - 1;
        }
        Console.WriteLine("{0} in\n{1} out", inRange, outRange);
    }

}
