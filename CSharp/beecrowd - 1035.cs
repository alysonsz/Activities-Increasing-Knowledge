using System; 

class URI {

    static void Main(string[] args) { 

        string[] values = Console.ReadLine().Split(' ');
        int value1 = int.Parse(values[0]);
        int value2 = int.Parse(values[1]);
        int value3 = int.Parse(values[2]);
        int value4 = int.Parse(values[3]);
        if ((value2 > value3) && (value4 > value1) && ((value3 + value4) > (value1 + value2)) && (value3 > 0) && (value4 > 0) && (value1 % 2 == 0)){
            Console.WriteLine("Valores aceitos");
        }
        else{
            Console.WriteLine("Valores nao aceitos");
        }
    }

}
