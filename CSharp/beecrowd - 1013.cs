using System; 

class URI {

    static void Main(string[] args) { 
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);
        int maiorAB;
        int maiorABC;
        maiorAB = ((a+b+Math.Abs(a-b)))/2;
        maiorABC = ((maiorAB+c+Math.Abs(maiorAB-c)))/2;
        Console.WriteLine("{0} eh o maior",maiorABC);
    }

}
