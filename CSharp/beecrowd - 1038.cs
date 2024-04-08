using System; 

class URI {

    static void Main(string[] args) { 

        string[] codes = Console.ReadLine().Split(' ');
        int code1 = int.Parse(codes[0]);
        int code2 = int.Parse(codes[1]);
        double value = 0;
        if(code1 == 1){
            value = (value + 4) * code2;
        }
        else if(code1 == 2){
            value = (value + 4.50) * code2;
        }
        else if(code1 == 3){
            value = (value + 5) * code2;
        }
        else if(code1 == 4){
            value = (value + 2) * code2;
        }
        else if(code1 == 5){
            value = (value + 1.50) * code2;
        }
        Console.WriteLine("Total: R$ {0:0.00}", value);
    }

}
