using System; 

class URI {

    static void Main(string[] args) { 

        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++){
            Console.WriteLine("{0} {1} {2}", i, i*i, i*i*i);
        }

    }

}
