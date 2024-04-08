using System; 

class URI {

    static void Main(string[] args) { 
        int grenais = 0;
        int quantInter = 0;
        int quantGre = 0;
        int draw = 0;
        int choice = 0;
        while(true){
            grenais = grenais + 1;
            string[] goals = Console.ReadLine().Split(' ');
            int inter = int.Parse(goals[0]);
            int gremio = int.Parse(goals[1]);
            
            if (inter > gremio){
                quantInter = quantInter + 1;
            }
            else if (gremio > inter){
                quantGre = quantGre + 1;
            }
            else if (inter == gremio){
                draw = draw + 1;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                continue;
            }
            if (choice == 2){
                break;
            }
        }
        Console.WriteLine("{0} grenais", grenais);
        Console.WriteLine("Inter:{0}", quantInter);
        Console.WriteLine("Gremio:{0}", quantGre);
        Console.WriteLine("Empates:{0}", draw);
        if (quantInter > quantGre){
            Console.WriteLine("Inter venceu mais");
        }
        else if (quantGre > quantInter){
            Console.WriteLine("Gremio venceu mais");
        }
        if (quantInter == quantGre){
            Console.WriteLine("Não houve vencedor");
        }
    }

}
