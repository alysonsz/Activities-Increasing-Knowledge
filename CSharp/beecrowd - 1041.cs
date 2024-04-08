using System; 

class URI {

    static void Main(string[] args) { 

        string[] value = Console.ReadLine().Split(' ');
        float num1 = float.Parse(value[0]);
        float num2 = float.Parse(value[1]);
        if(num1 == 0 && num2 == 0){
            Console.WriteLine("Origem");
        }
        else if(num1 > 0 && num2 > 0){
            Console.WriteLine("Q1");
        }
        else if(num1 < 0 && num2 > 0){
            Console.WriteLine("Q2");
        }
        else if(num1 < 0 && num2 < 0){
            Console.WriteLine("Q3");
        }
        else if(num1 > 0 && num2 < 0){
            Console.WriteLine("Q4");
        }
        else if(num2 == 0){
            Console.WriteLine("Eixo X");
        }
        else if(num1 == 0){
            Console.WriteLine("Eixo Y");
        }

    }

}
