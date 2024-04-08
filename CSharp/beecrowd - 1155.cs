using System; 

class URI {

    static void Main(string[] args) {
        double sum = 0;
        double n = 0;
        for (double i = 1; i <= 100; i++){
            n = 1/i;
            sum = sum + n;
        }
        Console.WriteLine("{0:0.00}", sum);

    }

}
