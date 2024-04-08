using System; 

class URI {

    static void Main(string[] args) { 

        int cases = int.Parse(Console.ReadLine());
        int rabbit = 0;
        int rat = 0;
        int frog = 0;
        for (int i = 0; i < cases; i++){
            string[] input = Console.ReadLine().Split();
            int num = int.Parse(input[0]);
            string animal = input[1];
            
            if (animal == "C"){
                rabbit = rabbit + num;
            }
            else if (animal == "R"){
                rat = rat + num;
            }
            else if (animal == "S"){
                frog = frog + num;
            }
        }
        int total = rabbit + rat + frog;
        double percentRabbit = (rabbit/(double)total) * 100;
        double percentRat = (rat/(double)total) * 100;
        double percentFrog = (frog/(double)total) * 100;
        Console.WriteLine("Total: {0} cobaias", total);
        Console.WriteLine("Total de coelhos: {0}", rabbit);
        Console.WriteLine("Total de ratos: {0}", rat);
        Console.WriteLine("Total de sapos: {0}", frog);
        Console.WriteLine("Percentual de coelhos: {0:0.00} %", percentRabbit);
        Console.WriteLine("Percentual de ratos: {0:0.00} %", percentRat);
        Console.WriteLine("Percentual de sapos: {0:0.00} %", percentFrog);

    }

}
