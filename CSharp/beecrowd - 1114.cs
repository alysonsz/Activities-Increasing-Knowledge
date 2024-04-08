using System; 

class URI {

    static void Main(string[] args) { 

        while(true){
            int password = int.Parse(Console.ReadLine());
            if (password == 2002){
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else{
                Console.WriteLine("Senha Invalida");
                continue;
            }
        }

    }

}
