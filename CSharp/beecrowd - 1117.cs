using System; 

class URI {

    static void Main(string[] args) { 
        int n = 0;
        double average = 0;
        while(true){
            double score = double.Parse(Console.ReadLine());
            if (score < 0 || score > 10){
                Console.WriteLine("nota invalida");
                continue;
            }
            else{
                average = average + score;
                n = n + 1;
                if (n == 2){
                    average = average/2;
                    break;
                }
            }
        }
        Console.WriteLine("media = {0:0.00}", average);

    }

}
