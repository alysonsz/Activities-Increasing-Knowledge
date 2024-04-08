using System; 

class URI {

    static void Main(string[] args) { 

        string[] values = Console.ReadLine().Split(' ');
        int num1 = int.Parse(values[0]);
        int num2 = int.Parse(values[1]);
        if ((num1 % num2 == 0) || (num2 % num1 == 0)){
            Console.WriteLine("Sao Multiplos");
        }
        else{
            Console.WriteLine("Nao sao Multiplos");
        }

    }

}
