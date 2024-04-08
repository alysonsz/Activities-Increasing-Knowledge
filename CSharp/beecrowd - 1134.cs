using System; 

class URI {

    static void Main(string[] args) { 
        int alcohol = 0;
        int gasoline = 0;
        int diesel = 0;
        
        while(true){
            int num = int.Parse(Console.ReadLine());
            if (num == 4){
                break;
            }
            else if (num == 1){
                alcohol = alcohol + 1;
            }
            else if (num == 2){
                gasoline = gasoline + 1;
            }
            else if (num == 3){
                diesel = diesel + 1;
            }
        }
        Console.WriteLine("MUITO OBRIGADO\nAlcool: {0}\nGasolina: {1}\nDiesel: {2}", alcohol, gasoline, diesel);
        

    }

}
