using System; 

class URI {

    static void Main(string[] args) { 

        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("N[{0}] = {1}", 0, num);
        for (int i = 1; i < 10; i++){
            num = num * 2;
            Console.WriteLine("N[{0}] = {1}", i, num);
        }

    }

}
